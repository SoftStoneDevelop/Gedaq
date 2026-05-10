

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
    internal partial interface IGuidListuuidArray
    {
    }
    
    internal partial class GuidListuuidArray : IGuidListuuidArray
    {


#region TestData

        private readonly GuiduuidArray2M[] _testData = new GuiduuidArray2M[]
        {
            new GuiduuidArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("80a50f44-02d1-4443-95be-0531e983ee1c"),

Guid.Parse("47e6c7fb-bbac-47d0-be06-184ce338dfdd"),

Guid.Parse("b58d8b32-b68b-471d-82c1-506853816568"),

Guid.Parse("9793f071-1230-45fe-b1fe-2d41813a3c2d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6b7cc99d-6dc6-4ceb-8629-e0250f0d6717"),

Guid.Parse("75fdf296-934f-48b2-bc27-685ae593c1f6"),

Guid.Parse("755ee1f3-dfb1-4bbd-a46d-b6b471034709"),

Guid.Parse("d8e36e02-3db7-4bf2-ae79-9da294b88451"),

},
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6c6909fc-d16a-44cf-97ea-595ddb78cfe4"),

Guid.Parse("ecfaef74-c08f-4f62-bb57-f25ee59e7dd2"),

Guid.Parse("c06a4d98-891c-4f36-a711-357ed20f344f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ff02f8a2-1753-4807-bde3-ca8866267760"),

Guid.Parse("88fc7971-cb50-4840-8af2-c475282d3df8"),

Guid.Parse("0c8265b5-f647-4ce1-9c15-9848c0b14050"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("571871a3-204b-48a0-8d69-7c4e65a0ee66"),

Guid.Parse("639d97c5-d25a-4d3f-ba7e-0896933095ca"),

Guid.Parse("e077c5b2-0c92-4587-9a6f-6435a6d68caa"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6a5f3443-e10a-49bc-8b91-24fc28b7a5f2"),

Guid.Parse("6a569747-fca1-4686-aeb2-3a29cfab7a58"),

Guid.Parse("fc5e74ce-cdbd-42d3-a1cd-0fc18b79e93b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e5074678-e6e4-4a44-aa61-2d9223caecb8"),

Guid.Parse("2d3acd06-e565-4a5c-89fa-ea1fbb2a927e"),

Guid.Parse("6aba4896-f299-4bd5-8a66-e2d861a94d2e"),

},
},
            new GuiduuidArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0437ffa7-0f03-4b5f-ba4c-1534b8b772d8"),

Guid.Parse("fe130481-aeeb-43f8-b15f-eca276704ed8"),

Guid.Parse("e139db7a-c12e-40ed-a52b-76630f5da60d"),

Guid.Parse("9eee3be8-81ed-4f85-a6a0-de12b117d36f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("65539d5e-206c-4c5c-94e0-f95aa52d4f92"),

Guid.Parse("9c34daf3-c83b-4f07-85ba-52a8c59ac674"),

Guid.Parse("682055d0-ff38-4bf5-a8b5-21fcebd05336"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a691b42e-165e-4407-a7e0-df385fbadc68"),

Guid.Parse("7f947849-4210-41c2-a310-db9b92f47aef"),

Guid.Parse("73aa3b25-6f6c-4425-bf7a-166ddf15cc56"),

Guid.Parse("f98bfe09-e749-43fa-aa48-21b7682e33ea"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("536fb521-dca6-40ee-880a-87ad04b8f7e4"),

Guid.Parse("e2481d6b-cf3a-4f68-bfa2-5c525e3bf68b"),

Guid.Parse("802e8edc-1e66-4d80-8432-19f271125178"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cb461f75-1f55-4bff-8633-0ab727c9d1ba"),

Guid.Parse("65454a26-4805-41ef-9f3d-17b0ad66433e"),

Guid.Parse("196b40d9-c648-4b04-8801-972fca59c772"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9be31910-ae8f-4fd3-a8a9-470541f4a944"),

Guid.Parse("ab13d8da-d419-42b2-8e20-9288158ba4b5"),

Guid.Parse("dda1516b-112f-4bbf-b3c6-3687bc0127d9"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec91e135-a8b9-4270-8087-5b72f1b4bb9d"),

Guid.Parse("697b0b9f-0780-452e-90d6-350da5f8e8bd"),

Guid.Parse("08898362-9659-467b-82c2-2194eb853b27"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("031b357a-ca95-4fdb-8069-b3b073c37725"),

Guid.Parse("2f50fd6d-286d-4af1-a23d-642b0d907463"),

Guid.Parse("0cc9c50b-49a6-48f2-8d72-347e55e5bcb8"),

},
},
            new GuiduuidArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("75c8f622-e8da-4b65-8bc3-40099279aacc"),

Guid.Parse("e36b9665-165d-4354-abdb-80bce8d6d018"),

Guid.Parse("6f078451-f5bf-4dcc-b918-2c9465c5bb11"),

Guid.Parse("cdb5f2a1-1caf-4311-9503-3c2ac6e32fc3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("97e27133-22e5-47d1-8732-f992ce1f04ba"),

Guid.Parse("8aaf2e5e-bc3e-4e3e-b37a-98b0167cba0b"),

Guid.Parse("907db81b-01ec-4b40-acbb-7aec978d16a7"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2383c6b5-e3e1-436a-b396-8ee190b1f1d6"),

Guid.Parse("3994bbcc-7792-4d46-9889-c848cbca143e"),

Guid.Parse("d4656840-ff31-4f6e-8666-b523533bc5b1"),

Guid.Parse("70a7b6c3-71dd-4bf9-95be-441e4c5db189"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("120f7a19-4ba7-49e0-b0fa-521fdb93dc0c"),

Guid.Parse("b7be6921-2d6b-425f-a596-a30fc1392a4f"),

Guid.Parse("bfb14bc2-dec8-4afe-9ef1-99fcfbaadc0f"),

Guid.Parse("4cc56772-fe0b-4295-914c-5f70456899e8"),

},
},
            new GuiduuidArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("257a97d1-eacd-4489-a0cd-0fa6c8822f8b"),

Guid.Parse("6f826277-ecbc-45f8-967c-f2a493a5fe0d"),

Guid.Parse("69c1dec2-3008-48c1-a9af-2034884e9a17"),

Guid.Parse("d5acc126-058d-4cc8-933f-176a636c4f51"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dcdbf8ad-6c30-4e79-8964-be071e738675"),

Guid.Parse("232661fe-0e36-41da-ab0a-1c0898e902aa"),

Guid.Parse("724c7597-4e58-4c69-bf2b-c9db9a10ab2c"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b5bd8d79-2bc0-492f-afe0-94a97c1e9ec3"),

Guid.Parse("ea622fd7-17a2-424a-94a8-304600224ac1"),

Guid.Parse("6c568b76-86d1-4196-935d-ce5a95a2c925"),

Guid.Parse("8f68d3e3-f32a-4c3b-8aee-89f0eed08fa9"),

},
},
            new GuiduuidArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("52d8eea8-17cc-4fca-84d3-9cd8e53a3aa6"),

Guid.Parse("18a1eb51-1199-4d52-94d7-5e2afb169156"),

Guid.Parse("c4915de8-21d1-4e71-ad4f-baa18e6d2ca3"),

Guid.Parse("b58e0897-ec1e-4eaa-90b5-2acd4ecbb126"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b63b9e1d-d859-4b3d-9d7b-2c473ad9c9c9"),

Guid.Parse("0c35f7dd-4736-400f-ad0d-f92bcbc10878"),

Guid.Parse("d69c280c-7098-4757-90cf-124bb97374a4"),

Guid.Parse("a0d24391-8301-411e-938b-d0cc11381744"),

},
},
            new GuiduuidArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("de1e5229-7c7c-45c5-8ba0-6239e744bdcb"),

Guid.Parse("d1b19543-1180-4b2f-903f-67e2eafdde9d"),

Guid.Parse("070e6268-18e2-4458-be35-6e4d31f46817"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d745f978-8eea-4e19-8829-6b8e29abcf6c"),

Guid.Parse("3aa94a11-1c4c-4149-bd23-278ce36adfea"),

Guid.Parse("d2daed41-50aa-4754-a379-cbde7a4baf30"),

Guid.Parse("638a00d5-41f9-4b97-8a16-8a8902a98abb"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f0254616-0ebc-4101-b909-8816e80730dc"),

Guid.Parse("9328ae09-3d94-4e2f-aeb1-0380b53df2db"),

Guid.Parse("b2ef5bdd-4fef-4633-a6c1-118a06257c60"),

Guid.Parse("59b2bf78-3921-4974-8caf-654738e17b08"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3b92299b-2101-4ca9-ad21-f56980109b36"),

Guid.Parse("462f4f16-a50c-4bbd-bedf-e2aa7275ffe7"),

Guid.Parse("9e2f81ff-536a-4a35-a7f2-873b4f58eb9e"),

Guid.Parse("e974dd30-6063-45d1-8929-e30e9f7d4f90"),

},
},
            new GuiduuidArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c2b26a78-3634-4662-91d9-9f2d5f496378"),

Guid.Parse("8e8ef58f-282f-4fa0-b18e-639598e7bb25"),

Guid.Parse("0eb5cc9f-68cb-4f63-894a-dc7456819bbc"),

Guid.Parse("1983a4a0-6f8c-4f2f-a9fe-d23ce8184f67"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9017e913-f7fa-4530-b373-2ee397b957a8"),

Guid.Parse("e2d0322c-2daa-41d4-9553-6448b385c511"),

Guid.Parse("32956de6-9935-40f6-812e-d0e50f36c978"),

},
},
            new GuiduuidArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("914c4d1f-0707-4d14-a69a-67ac25ce2a8b"),

Guid.Parse("bc9c08f9-261c-4cb8-a1f5-cd6da2dc9888"),

Guid.Parse("2cf713bd-3faa-4c1c-81be-cf0de64609c6"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0d92334c-eb22-4785-9533-9e2d1a0d97fb"),

Guid.Parse("7722da49-5832-4951-a490-34abb79a32a4"),

Guid.Parse("a1a5163b-a384-48e6-ba87-06d2d0abe725"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1607ce57-1f2e-4436-b129-50a697525e96"),

Guid.Parse("a17889e4-5e6b-4f02-9c27-0d47e206a2f2"),

Guid.Parse("96709dc7-be03-4700-9bc6-7092f4972134"),

Guid.Parse("477f931a-fd5b-4ba6-a95c-ec2660eb0a24"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c8b54576-04b3-46c7-a0cf-4adf5b1b5ca5"),

Guid.Parse("600e807c-160a-43de-ba85-69d42b63ac36"),

Guid.Parse("9b635adb-9a8d-44df-bbeb-e35c47c67ef5"),

},
},
            new GuiduuidArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("43463d42-1070-43b3-a6e2-d88e01066e0e"),

Guid.Parse("877b06ce-60b1-4223-9826-15e10c2f5a08"),

Guid.Parse("b6d666b7-d57f-41b6-be78-b0f0e3853957"),

Guid.Parse("05ad329a-a430-4e15-8704-314f773172f1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5a38aa81-f90c-463d-8949-56ba7a57c9bb"),

Guid.Parse("786e2cab-ac74-40e5-a6de-7a39f48991ca"),

Guid.Parse("7ec41da8-83fe-41b2-a684-ca884ebb4c2a"),

},
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cf675854-26db-4ecd-bb64-a3e9b4695f26"),

Guid.Parse("c4bdf665-cc90-4afb-8a91-e1972610ddf8"),

Guid.Parse("05bbb3d9-4610-49a3-a4c6-187f62b0910f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3dddb39-24e8-4f3c-8da6-2bdf36c9d8e7"),

Guid.Parse("413d8d0e-3703-4d03-8357-298aa2f763d7"),

Guid.Parse("ee8669d9-b268-42ae-843f-ed8e06c11e73"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e8ac7d22-b3e2-4900-8eaa-e2237c52bdea"),

Guid.Parse("3c70511d-e9bc-45bc-bc3a-c7cfbe9cdb16"),

Guid.Parse("599a85e0-411c-49eb-837f-397a0067cf8a"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("209a150a-2fc4-45af-a0c3-6dfdd4e52eaf"),

Guid.Parse("c3fc5a20-95a2-4a96-8403-772bbcaab087"),

Guid.Parse("42690525-80a0-4b15-885a-cb30a212e4d9"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6fcf129a-085c-49c4-8985-75d3bd16fa8e"),

Guid.Parse("650a8017-6fc5-4bc8-bc2a-0800551680f2"),

Guid.Parse("d06c4c89-f8a2-4ca7-a704-c0ae54df69b4"),

},
},
            new GuiduuidArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ff42001b-c792-458e-a790-f629f6ef5175"),

Guid.Parse("43e9a803-b03a-4112-8d03-cdf9d5a5e340"),

Guid.Parse("808ab70f-4b79-43bc-a871-896351a18e72"),

Guid.Parse("f442fa6a-8c81-4622-ba5a-46428c8ca72b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("08d2e2b4-c848-42a8-a6e2-7366f99adc81"),

Guid.Parse("51fbd3ed-d661-492a-8217-36d7014744ce"),

Guid.Parse("05ac8368-b229-493f-9aa8-6a6c10b3be96"),

Guid.Parse("a3113b4b-80bd-49b2-9ec8-70a85b1e62fc"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a7004560-c64a-4fee-8476-4e60620f4d22"),

Guid.Parse("29d8f297-218a-484f-af7a-67a1240a12ef"),

Guid.Parse("37503bd1-fc03-4fd8-b9d1-88f0eec4b10d"),

Guid.Parse("b9b7cdbb-5155-43b0-8601-eb931b19a391"),

},
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7630429d-b5eb-4f13-859d-3dbfad0b3060"),

Guid.Parse("9b7c1b02-5c8f-4713-91e4-2b7f06ce812f"),

Guid.Parse("1c005672-aecc-4a80-9c12-14623757e77d"),

Guid.Parse("884433ca-ba9e-48f2-b89e-8fd5204839b9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7cc7d949-a125-458a-b66e-87c6fee3f464"),

Guid.Parse("f3b389ee-cb9d-4744-973e-abf6477175ce"),

Guid.Parse("38c898d6-a24c-41b0-995a-3128479b7592"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d12dd7c1-82a4-405d-9fff-a791d9cdb1f6"),

Guid.Parse("1313c5a1-6cb1-466d-a25b-d14975b1fa18"),

Guid.Parse("b1bb939d-ecae-47ad-ad2d-14f56d392b71"),

Guid.Parse("6f718906-5756-43ab-9905-38ed20354d85"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e449104f-5d6e-4ccb-91e8-61d16f8f1c57"),

Guid.Parse("025e2f3a-78b7-4bf7-a492-8e13aa1bcb9b"),

Guid.Parse("14b08cf6-3eb4-40e3-8316-b719cbe2c265"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c256e7b9-e4eb-48f7-a955-df963cae9db2"),

Guid.Parse("37cd53ed-7947-4ddd-ac3c-37d5e3dcd371"),

Guid.Parse("2b930b2b-9d0b-44c0-a242-63f7b4755e98"),

},
},
            new GuiduuidArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0e0d43a1-d9f5-4fc4-893d-47ef0624961a"),

Guid.Parse("38c7682c-76d2-4b84-b63f-e9937ab292f0"),

Guid.Parse("72bd3d52-7b17-434c-a9d5-3f8296ae6c1c"),

Guid.Parse("cf10fedb-157c-4bc4-8901-c0cf1c355ffb"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("18ca2580-f74c-4222-b267-56b44a8fe9ab"),

Guid.Parse("f5761176-2a4d-4723-9b37-1ca4bb535525"),

Guid.Parse("35fc7389-2964-4a5e-81ce-238afbe9fdf3"),

Guid.Parse("c6685e63-4a0a-4de3-8907-4aff016c125a"),

},
},
            new GuiduuidArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8f9ea480-aeee-4e2c-b6e2-6791e3d82da7"),

Guid.Parse("db8478d6-ed07-4014-b9ab-91d68ec9f2ac"),

Guid.Parse("86cd6dbf-9eb6-491c-ba03-182b1e4963bd"),

Guid.Parse("ee3e9343-4ca8-4a7d-a8fb-0955952e1b21"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bcc17cd2-37f6-4065-961f-ed25c52cb2c2"),

Guid.Parse("f0a0a292-0350-4d6a-b0eb-fefe2ebf788f"),

Guid.Parse("c1370899-fee2-48ba-bf97-9e18e2957ea7"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("83d8f177-852f-444f-a8e1-a5109cd1145f"),

Guid.Parse("9660db9e-5a3c-4573-b7d8-bbbfbf6d0e16"),

Guid.Parse("a472aa86-0f5e-4137-8daa-209091149e59"),

Guid.Parse("92437a73-db8e-4692-89ff-2f47b205bd51"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7c19ccd9-d80a-46a4-aa6e-85efa8cc60cb"),

Guid.Parse("ab9d50be-73fc-48ab-a473-fb59488bec6d"),

Guid.Parse("c189115d-f423-4248-bee2-d9a82f64606e"),

Guid.Parse("a7170bcc-d34d-4e19-9a86-ac4c5005aeef"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0efceba2-293e-4a9b-94f9-cc56a1c767f6"),

Guid.Parse("7d2bdced-a4ad-43d9-8328-81c89e574bdd"),

Guid.Parse("abc7478e-a5d6-4070-a4c8-d4c57c8bf4f7"),

Guid.Parse("f163eb8f-4de7-4abd-834a-1ce75cdebacc"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ae80263b-0ba1-44ef-aea4-0a55451df99a"),

Guid.Parse("57360ebd-7748-4b89-9f1a-680990f7f586"),

Guid.Parse("7c5c27c9-3b45-4650-9bd7-146055ead4da"),

},
},
            new GuiduuidArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2aa3b15e-e11b-4bb6-bc4b-cdceae0f0c7f"),

Guid.Parse("4abb5fb0-ac27-4867-8e08-d5f0e141e707"),

Guid.Parse("c78903e9-0592-4b05-9837-852d534d015a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8a8ce557-ff52-456f-83ea-139d222abcf0"),

Guid.Parse("48035a89-53be-4c51-b32d-dac488189614"),

Guid.Parse("a8cae869-91a1-479a-a62f-8e81e9237dcf"),

Guid.Parse("36860df9-06f1-417c-9dba-16608161700c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dbe147ec-866e-4105-a8e4-ba6284697423"),

Guid.Parse("10b2436b-1ecb-4b28-8290-81275c42d490"),

Guid.Parse("c7effa77-0687-4a41-9f20-50e5d5240f5e"),

Guid.Parse("04a20c03-16cd-400d-813c-10c818f7c30e"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e67001a3-1704-4faa-b782-a185e597aead"),

Guid.Parse("97aa7527-cbf4-4e98-b797-67cc55fbcc9a"),

Guid.Parse("bc885d2a-9f7c-48c1-88fb-5277266cdbf6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3a8de382-8696-4fbe-8a0d-edaeb4e034a6"),

Guid.Parse("00286504-d1f8-4d3e-92a7-48b84381f769"),

Guid.Parse("8371e096-6ea5-4e52-aee6-fd12f8e00cc3"),

},
},
            new GuiduuidArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3bf7728a-4f31-4462-806c-ee6cfeadc458"),

Guid.Parse("7361a6f2-9df2-45f9-b5bd-9eeb2de78c49"),

Guid.Parse("195cc8b5-f614-479b-8b19-9ac65ca64d6a"),

Guid.Parse("b4c4df0d-e18a-4227-b3aa-21730e632085"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3c2c6ace-4ced-4b0b-9654-bda486698df6"),

Guid.Parse("289c5e71-5cf7-4519-9c37-070cfca8c2aa"),

Guid.Parse("573b33d5-7747-4ab7-b0e2-fedf78cf376f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("97b8a188-ffaa-44de-9092-c12fba2fda62"),

Guid.Parse("80f4b647-dde4-4a37-bd64-63397fb3ae9b"),

Guid.Parse("5258dceb-23ec-4ad0-bf45-1597ce9c592e"),

Guid.Parse("66c1b3fc-1846-43de-bfb4-7a21dc536976"),

},
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b434b98a-fa51-4a02-a4c5-e0c2d7cf839a"),

Guid.Parse("2c8e2146-40df-48bf-ac55-bcde18987b06"),

Guid.Parse("6db17232-5737-4358-a922-72bc36b7e2ad"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d6a67392-f57c-446c-a4b0-3d68b3ba8c78"),

Guid.Parse("c0f469c9-ff49-4065-9d9d-33f2e56473ed"),

Guid.Parse("a67019bc-3f33-43dd-a056-955bfb8db81b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3846496-2fe7-47ec-9fb0-2d64ff346ef5"),

Guid.Parse("8890f4a9-0f9e-4947-b6b4-0d7b1b5a5f0c"),

Guid.Parse("acd8ae88-09e9-4bb7-b952-0f05833fd8b4"),

Guid.Parse("225d609c-4ea7-4fea-ad33-248ec372b578"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fcbe4627-6cb4-4f12-be53-62625af4e0cc"),

Guid.Parse("a0a88aa1-22d8-4e3a-8902-6a3996d119f9"),

Guid.Parse("fd25a39b-c52c-41f7-a7d3-32256fef75b7"),

},
},
            new GuiduuidArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("356f15c4-e0e0-4a5a-a2bc-33bcc92d2a8d"),

Guid.Parse("2a463771-1cb2-4d54-bc42-00ee861ace26"),

Guid.Parse("607d5dbd-91c4-4949-8fa2-31faf689abd7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7107497a-7f15-43a2-a2b1-fcfb70548419"),

Guid.Parse("0ddab2de-da8e-49f8-ac4e-a68e6b3a2102"),

Guid.Parse("c36e5f28-cd90-4633-b7f7-a9f24342dc3e"),

Guid.Parse("0ac4a3d5-21e8-4bed-9484-6e0218153065"),

},
},
            new GuiduuidArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2fd71085-4329-4ec3-8a6a-5b00f532fd61"),

Guid.Parse("c8ec39be-5fb8-447b-ad9f-24906e353c8e"),

Guid.Parse("15d5abab-1fd8-4d09-8c6f-9fd4987c6ee5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("60ba745b-3b8e-4e1d-b9a4-752cb1a3c2e7"),

Guid.Parse("a1b69b84-96c6-4d4b-bf88-ad6225960cc1"),

Guid.Parse("288ea034-de6f-4097-bb75-75a78679345a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("48989cfa-830a-4ea0-83cf-e045d47dc912"),

Guid.Parse("37d25856-1f7f-4d9d-98ab-91fd69c14543"),

Guid.Parse("30447ae0-d0ea-4b59-9fb0-ace2bbfc2d54"),

Guid.Parse("338b4eb7-3ea9-43dc-94df-68eb68bdde16"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8bfb3eed-3c04-4fcc-adb6-f78ca678dc0f"),

Guid.Parse("28cb97c1-a042-4beb-bf03-ff2116000364"),

Guid.Parse("4971ac30-a73b-494b-b47e-31a670ad86f3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("104a2a65-fece-4b33-9fe7-81e21515d64d"),

Guid.Parse("1c7c4531-9bfe-435c-b54b-adc679fd6e6e"),

Guid.Parse("d7fd2531-44bb-469c-8449-f730e6656329"),

},
},
            new GuiduuidArray2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9e0e6203-8384-4d33-8a68-f888bad235ad"),

Guid.Parse("fc2babdb-156a-4059-be4f-298385271ced"),

Guid.Parse("3eed4f32-824d-4acf-b658-3b334be5ad29"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f17ef1f9-785c-478a-9e02-b341d21a41b8"),

Guid.Parse("646e1d41-2557-4ff5-a233-4389509d9f0a"),

Guid.Parse("877649fc-b2f1-4a3e-8051-f1eea2dcc0e8"),

Guid.Parse("6d5b9315-18fc-4ae2-bb13-b995a49faf38"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("11f5dbe7-7799-4ac9-97e8-83ee04b47146"),

Guid.Parse("bcc03458-72b1-4142-bae2-d9b381f2fa0b"),

Guid.Parse("a638cc84-25aa-4842-a34a-ae84ed26b2f1"),

Guid.Parse("0bcf7780-372a-4757-a934-9ef5a5ca62c8"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 202,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3fedcd28-410c-4c4d-9055-d5c28b32d41b"),

Guid.Parse("8a2b5394-5341-457d-b4be-3b420e0718de"),

Guid.Parse("96ab645d-9b5d-4a6e-9a3e-529b8033dcfd"),

Guid.Parse("965dff6f-80e4-4dcb-8fbc-8c3263315a02"),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
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

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
            asPartInterface: typeof(IGuidListuuidArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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
                List<GuiduuidArray2M> models = null;

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray2M> models = null;

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 5;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 189;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidArray2M.AssertModel(models[0],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidArray2M.AssertModel(models[0],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 60, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 82, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 135, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 180, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 19, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 144, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 5, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 64, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidArray2M.AssertModel(models[0],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 57, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 153);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                GuiduuidArray2M.AssertModel(models[0],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                GuiduuidArray2M.AssertModel(models[0],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray2M),
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
            asPartInterface: typeof(IGuidListuuidArray))]
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
FROM public.binary_guiduuidarray2m m
LEFT JOIN public.binary_guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models =  ((IGuidListuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI), typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                await ((IGuidListuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                ((IGuidListuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

