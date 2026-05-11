

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
    internal partial interface IGuidMArrayMArrayD2
    {
    }
    
    internal partial class GuidMArrayMArrayD2 : IGuidMArrayMArrayD2
    {


#region TestData

        private readonly GuidMArrayD2E1M[] _testData = new GuidMArrayD2E1M[]
        {
            new GuidMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Guid[,] { { Guid.Parse("e55a956e-2566-42f9-9203-2d398010991b"), Guid.Parse("0cb0b36c-5520-43bb-885c-71e45f028802"), }, { Guid.Parse("e62a8906-57cb-42dd-97cc-1da4ac08ae55"), Guid.Parse("01d29596-4b5a-455f-a49f-a4c4431f8d68"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Guid[,] { { Guid.Parse("8e64beac-77b6-4ae1-9a88-91e4f78eadde"), Guid.Parse("b6c47d06-d324-4bb9-bca0-05e02e6b34cb"), }, { Guid.Parse("359cb2be-a93a-4f02-ad74-a2db5ac0345a"), Guid.Parse("65e47628-b5b4-4940-821a-92f5f0c91b68"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6f1e0649-78fa-4195-8b91-fa1572d34658"), Guid.Parse("d7fe18aa-37b0-48aa-8d84-df73b47eec3c"), }, { Guid.Parse("ee7d5b4f-b086-447c-83ad-91c289455c2b"), Guid.Parse("71868f31-1960-4849-abae-7274f1fbc4df"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d312571a-908f-4aa0-896b-8ca6afb5566b"), Guid.Parse("6db6c021-691a-4c24-9be9-7026882c49e8"), }, { Guid.Parse("10288609-4afc-4a9d-bd90-f49d7a578ca5"), Guid.Parse("ce244c28-c722-4786-807f-9de4786c67f2"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("cf57da3f-d2fb-4171-bb6d-201f83b164b3"), Guid.Parse("60e532dc-9b7f-44f7-96c6-4cd270a5adb3"), }, { Guid.Parse("4798ec32-5a9b-44a8-be1b-a2957454d4e0"), Guid.Parse("613d9bca-85d1-49d5-9a05-78d199438b6f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("cf217353-cd1f-44d8-8512-876c8590bd09"), Guid.Parse("93794b6e-e569-44b9-b47b-0279272b1e39"), }, { Guid.Parse("3cf5e41a-dca2-42fc-8b4c-af175389f0a2"), Guid.Parse("6e955308-5588-4dce-83f4-a40770887081"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c9b064cf-0a7f-44fc-aa7a-0d4dcf777631"), Guid.Parse("3454c3f2-c2fb-4035-9a16-de7bd1fb5115"), }, { Guid.Parse("8343a861-8082-4b5a-ad0f-cec390112ec8"), Guid.Parse("08e49605-1a85-4fcc-a859-76c8170242d0"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Guid[,] { { Guid.Parse("b89c18b8-6b62-48bd-91e2-39f6a0f6931b"), Guid.Parse("a8db1abe-8399-426e-a18e-f7ab4393208a"), }, { Guid.Parse("2f1f45f9-d6cb-4e47-9162-86552a8ed4a7"), Guid.Parse("bcf719ec-3dd4-48c9-99e3-3ef9362fdfa0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("03b73452-405a-431b-aa98-07b7b05c5617"), Guid.Parse("0c2e6d35-8dcb-4897-9100-42e7320c3178"), }, { Guid.Parse("930df379-1d60-417b-bb89-5f2b50a36216"), Guid.Parse("aa782bf1-0ad2-4ef4-b35e-73512d0a2500"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("b704ee29-6d64-4441-90cb-02c14a0cb51d"), Guid.Parse("c086f0e5-cb9b-43df-8b3e-b059f45ee46c"), }, { Guid.Parse("12859159-97e4-4ed4-87ed-038d00d5dd39"), Guid.Parse("24b2b5ca-bb33-4dce-9b34-2a6146e4553a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("f7a407fd-2145-450a-950b-4ef680721bc6"), Guid.Parse("0f28e5a9-3627-40cc-99d3-07f607a1fea8"), }, { Guid.Parse("6b443ffc-c09f-4467-8600-5bb89f33ed78"), Guid.Parse("b8f2531b-952e-4846-83f5-ff964151ff9c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("be82881e-47ee-4534-8d43-169d456faa75"), Guid.Parse("e5f24374-33a9-4d48-af67-728006ab407f"), }, { Guid.Parse("aa568569-b4f7-4dc0-93c1-56c0a93c1378"), Guid.Parse("8cf4cbf7-145c-4c76-b601-30ff7dc5532d"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("40bd32dc-7525-4263-b872-ba83641a3cdd"), Guid.Parse("8ac1af30-ae0a-416f-85ff-4ef4d9b25e76"), }, { Guid.Parse("bc057a2b-2219-40ac-b4b5-749dcb0866f7"), Guid.Parse("08e00d1f-65fd-4e23-abf2-358d66b444c2"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("74127f1d-3ba6-4469-b88a-f3a46a4fb104"), Guid.Parse("9fd39d3a-1acd-4662-b986-0d5d9b4320cd"), }, { Guid.Parse("784ef738-e013-462f-b444-ac67a193340c"), Guid.Parse("8bf860b6-457e-4bb3-914f-3f14ca13fd59"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("0be839e4-3b1b-4bea-8dc7-cc8848753709"), Guid.Parse("c6dcacae-9cf2-4c9e-b4e5-37de9e41584f"), }, { Guid.Parse("d9d416ce-9441-48bd-a1d2-df096c2469ee"), Guid.Parse("abb9d8e4-eb74-412b-bac6-edde819d3b8b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("44274559-a51a-40cf-bf45-ceaaf9e44921"), Guid.Parse("028dfba9-c08a-48e2-a490-8b3f55cbe7e0"), }, { Guid.Parse("38b6f6cf-0c9a-4c15-b437-829a4c852cbd"), Guid.Parse("ca9ef2b3-9e14-4a71-b61c-412a85f75331"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Guid[,] { { Guid.Parse("c1fda5ef-ad05-4af4-8932-6c3affe4174f"), Guid.Parse("944d7749-1e18-4239-b22f-43a6973695d5"), }, { Guid.Parse("5bdf8e61-1895-418f-9904-03f681c64219"), Guid.Parse("c928ceab-7bc0-4452-a7ee-8220b7b7961b"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("ccb339af-560f-4b2b-8a21-217a860da73b"), Guid.Parse("a1b439f1-ec86-46ac-aa85-23aef519e622"), }, { Guid.Parse("11886bb2-98de-4f34-9a5a-8c611f53ebc4"), Guid.Parse("caa33b90-02b5-4f99-af95-aea34e0066bb"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("194a8789-3238-4c9d-be38-4a8851ce2a4f"), Guid.Parse("82308cb8-0d81-451d-9a9d-3576cc6eaeb5"), }, { Guid.Parse("1844a4cc-02b9-4ee9-a0a1-c5e2d2e92a05"), Guid.Parse("33a95b30-8fb1-4f77-b40b-b12a2672df79"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("18b933c0-872d-42a9-8fa0-08371bbdb52e"), Guid.Parse("b798f31f-f17f-4bd3-9f1e-c4a42691bb64"), }, { Guid.Parse("54c8fedd-ed47-46d9-bd65-56e74d15e62e"), Guid.Parse("f10b0097-23be-4fba-86e3-dedb08568126"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("e33e33bf-0572-49c3-813c-682f93685f13"), Guid.Parse("b625ebe2-e9d0-486f-abd2-f6462786fef0"), }, { Guid.Parse("233ce658-87ce-43cc-ab62-81e09177b4b5"), Guid.Parse("8593102f-d68e-4d44-a676-6a3f71ecc513"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("0fe33061-619c-4829-9be7-9f26aaca896e"), Guid.Parse("334751b8-62c5-4e26-9df7-7978b6f12662"), }, { Guid.Parse("f4d32e21-d161-415a-b364-ffeba03c0fa1"), Guid.Parse("26627601-48b3-416c-9ec1-f543f6eba75a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5cd8a8a1-aeea-4c9d-90c3-36dbb75f0198"), Guid.Parse("19c334b8-b2b8-4c46-bc57-550168a65cfe"), }, { Guid.Parse("f6eed8c1-6b75-4c76-b6fe-9e2febc67d6e"), Guid.Parse("95ee0902-8b9b-45a7-a540-fab037099d0f"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("cb805f84-aa42-4209-8e25-6ff1a63baaf2"), Guid.Parse("6b794afa-5206-4f8d-b3da-15d4929ff4e4"), }, { Guid.Parse("f755311b-f743-49c6-aff0-8accb86a9897"), Guid.Parse("25f7aaf2-0880-4d94-b203-389f35144404"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Guid[,] { { Guid.Parse("0c3b46ac-1d3c-4084-b167-1407ed81a88a"), Guid.Parse("4d4c4176-d8a1-4e52-86d1-f3ff9ae915ca"), }, { Guid.Parse("cb5b30f7-c850-4551-b70c-f17cc9eaef39"), Guid.Parse("0c52c9dd-cc55-4ed5-b17a-da88cb3af01c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e990a00a-7233-4e97-a2e8-30fddf9fe6a8"), Guid.Parse("032394ba-6522-4a39-819d-bdd6486781db"), }, { Guid.Parse("44306416-5655-40cc-86d5-e1aa07b587cb"), Guid.Parse("253d1f6b-9278-4526-9e85-9915b5e717f0"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("8845121a-6cb2-4acf-b8ed-ad5b26ff8cb6"), Guid.Parse("26aafe8d-2207-4817-890f-333a9f21a155"), }, { Guid.Parse("9b9b1427-237d-4d3d-8d7d-ab0f07f4a88e"), Guid.Parse("b32f1fe3-e9e2-4df5-99b6-ec809896e509"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Guid[,] { { Guid.Parse("b80df4fc-3269-4e58-afe5-b9aabc026392"), Guid.Parse("cc498bca-22b6-4e1a-95b5-e52c849ecee8"), }, { Guid.Parse("eb888696-7210-40e9-b09f-59e217284965"), Guid.Parse("426367f6-7ecf-4fb0-87e3-be575710ca4c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b7111afc-57f7-4c64-aadf-e1b0a8705247"), Guid.Parse("660e1884-e447-4bd6-a372-d365f40edfca"), }, { Guid.Parse("bd370c12-a703-4c0b-806c-d543f955a295"), Guid.Parse("a7e8cc0b-8071-4e0e-b2a5-78b672734d02"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3eb7945d-6401-4a93-8d56-5e4327861b70"), Guid.Parse("37dfd77d-e14c-43d5-9e8c-d5f71d524163"), }, { Guid.Parse("c77f4784-2107-4120-a0ab-07ca8dfd29a5"), Guid.Parse("1f052519-596b-4174-ba2c-b8e4ad802a13"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("8db7d67b-a419-4cdc-8c29-9d7605697350"), Guid.Parse("3bc2b19e-3a59-430c-909e-936bcbd7ed7b"), }, { Guid.Parse("4143fa4f-f73b-4667-aef2-f0f386fc7c12"), Guid.Parse("24c54205-fdd2-40f7-bffd-359ae81aae60"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Guid[,] { { Guid.Parse("e7f12d0d-8ac0-4393-9e92-7253999ede40"), Guid.Parse("9c409a77-da8c-4752-9a8b-8c20d798547b"), }, { Guid.Parse("85aa0843-ecdb-4dba-aed5-3de57e63f572"), Guid.Parse("ffb37b34-815e-49f8-8318-120d7c087c06"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("361cb8a3-e17f-4eb8-aebb-fc790da4e996"), Guid.Parse("82c37286-8281-4fb1-ac9a-9c15502d36ca"), }, { Guid.Parse("8d83ca59-4533-411d-acc0-fd2fbdfca87a"), Guid.Parse("74bc3b49-0dfd-4652-8f84-70dab6a51efb"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("cca28a0f-4bbf-4762-8b75-6bf5882ecccf"), Guid.Parse("c94c6a34-5610-4ae3-9f0c-6822dde80350"), }, { Guid.Parse("547a4133-6d28-4b79-b96d-f2deeada8935"), Guid.Parse("d474f54b-4807-406d-b7b6-4ba24d4c9f52"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("f94967fb-6c89-4b8f-a1f0-01dbeaa2968f"), Guid.Parse("76de9790-41c7-4e01-b030-2d2eb224882d"), }, { Guid.Parse("d471d5a8-f7fa-48af-ac24-d9254b3bf869"), Guid.Parse("31b86644-9a86-4cc6-ad94-d91e3b8d9396"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("bca51f24-be08-4ba6-9bd4-4824424e04a4"), Guid.Parse("7948db26-08f2-4368-abd0-a094d183526c"), }, { Guid.Parse("cc4575a0-0b95-4a6b-acdc-85c44b31e2e1"), Guid.Parse("2e6684ec-ffc9-4cec-9cb1-3fa978a76f05"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("c6135acc-0b74-48c1-b2b5-8e2ab0383e70"), Guid.Parse("30e48aa6-c124-47da-9f48-0323df2a777e"), }, { Guid.Parse("ec5f0355-b91c-4924-b0a5-befecb407bb8"), Guid.Parse("c4a415ec-7b17-414c-87c0-82cb16c68c9e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("acc0ee1c-d5ba-4c43-87f5-7c5368ad0a25"), Guid.Parse("96f8e788-faa7-4fd6-bd90-eee90b2a6e9e"), }, { Guid.Parse("0e38bfe1-f42f-442d-88c8-0c3c68281867"), Guid.Parse("21814b3d-c0ec-4c30-a2ba-a0d627c2e68b"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("bde83f05-98f4-470f-93a8-e3a83ec53668"), Guid.Parse("1cb4e8fa-d135-48d9-b466-65e3ede28dd7"), }, { Guid.Parse("fe30b82c-3700-4230-8950-40f43846226c"), Guid.Parse("c37ecde1-31a9-42d1-985f-2446b1320c68"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("2d4947b6-2ee3-4b60-a674-9bde7fc61aeb"), Guid.Parse("283bf502-a031-4eb7-88b4-c85bd0b4e56d"), }, { Guid.Parse("4f115938-c23f-400b-9475-88d132e892fd"), Guid.Parse("4893ce93-df67-4d23-8550-b65902ffcbb4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("803b2d51-6566-4330-a32e-d1ca20e318c8"), Guid.Parse("856bc92f-37a4-4d98-bd03-8127992ff1c7"), }, { Guid.Parse("015ace1d-68fb-4836-9b8b-d860739ce175"), Guid.Parse("6e99d850-e2ef-4906-8cf4-933a1cc6fa83"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("0231518a-de11-40eb-886d-16478682eac0"), Guid.Parse("f0b5bb52-6918-4025-81d6-2d153e89c298"), }, { Guid.Parse("4b87aa67-13ea-4fa4-a12c-94687d24a594"), Guid.Parse("182763f9-9fcd-4812-8cba-ffbe3f9af532"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Guid[,] { { Guid.Parse("cdae1e55-9ecd-4ad4-a0e9-667d22fa784c"), Guid.Parse("1ec59be3-5d4b-425c-8610-dc108eb50348"), }, { Guid.Parse("3d160339-184b-48db-b60a-12e9c4c9a3a7"), Guid.Parse("10f43cc7-f98b-45ba-acb2-ef0ec17e2f5b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9f138c71-2e2c-4057-9ebb-12b9af76d73a"), Guid.Parse("48bddd7e-c565-4604-9226-fcb07a5314dc"), }, { Guid.Parse("cc92bedf-c9d1-4b61-a258-5201cd475f7b"), Guid.Parse("795acbfd-88cc-4151-89ad-4cda3255c060"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("92d5e6af-1104-4d72-bd76-2ec2d4aa8ab5"), Guid.Parse("1d590404-50e0-4b3c-b301-8ddb09ff3e3d"), }, { Guid.Parse("19086416-6063-49e7-b708-b049c75bd520"), Guid.Parse("bc4ede83-eb63-4a4a-bbc8-f22736021091"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Guid[,] { { Guid.Parse("5725d97d-0e43-4e54-9482-a0a9081545b6"), Guid.Parse("9160875e-a28b-4351-8f56-71e49070618b"), }, { Guid.Parse("be183af6-7085-4b5e-bcd1-b4fd8d723d5c"), Guid.Parse("f8a7cd6f-274f-48b0-a34f-747af0a389d5"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("1fcaf152-7d17-4b33-9a51-555b3074ea65"), Guid.Parse("eb972030-81d5-435e-8b6b-07a6cb334d3e"), }, { Guid.Parse("050ffaf7-cf5d-495e-a329-17c85b4909dd"), Guid.Parse("7c378a3d-1f60-420b-be04-0f871c252166"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("8372ea18-f6b4-4f08-a5a8-50a66216b106"), Guid.Parse("8b226200-863a-4990-ac7f-d72b9a2c40ac"), }, { Guid.Parse("8d5782ec-8b89-4596-9a7d-f624b2e0ffe6"), Guid.Parse("96160846-9091-4aa0-9aa1-037173826e18"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("5e172f41-8511-425a-848d-1b965e9af3c2"), Guid.Parse("17f4ecdd-94bb-4dc5-af2d-f9ed76ed28bc"), }, { Guid.Parse("7acc70b1-858d-4f2d-9448-e63863dcb582"), Guid.Parse("801567fa-27dd-44a1-a5b6-00c98ed0898d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d385bb4b-acda-4f95-8a52-38554b86e251"), Guid.Parse("0b6efe6b-0ee2-4622-ba09-56fcb62184a8"), }, { Guid.Parse("20b0db0f-c2e9-4015-925b-7f0981c2a57b"), Guid.Parse("5f901269-547a-49f7-9641-45fbee939098"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("d1df4889-e38d-4aca-bfd5-77c03ed69d5b"), Guid.Parse("b00c4025-a415-4066-b476-9f2f69dbca78"), }, { Guid.Parse("d7cc15e1-45e4-4606-ba1f-b894e00bc58a"), Guid.Parse("a377b379-9afd-40fe-8be5-bea309ebbc3e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("107a821a-35c8-4174-a25c-6f80531c3ec9"), Guid.Parse("ea6c725b-a5da-4f30-91e9-7449a3777ab3"), }, { Guid.Parse("d9974c87-ac18-4f43-a354-b66c404ed483"), Guid.Parse("37d3abc7-e1db-4178-a895-097470f3367b"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ba3e345f-692c-4ea2-b085-6c61238f98a8"), Guid.Parse("00ae90d5-e2bd-4164-af60-d4dd5b80a1e5"), }, { Guid.Parse("fc5f94c7-8583-430b-afd2-232058cbdc79"), Guid.Parse("416da9aa-a815-4ce8-9b3b-6046f7172a1e"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("96f7ab7d-43a7-4729-adcc-27fdae5e7cb9"), Guid.Parse("1b5e7205-1a20-42ba-a81c-eca2e35fd0fd"), }, { Guid.Parse("83a96584-697a-474a-8df2-d8c76aa6a2e7"), Guid.Parse("debeb450-5c9b-427c-b47f-7628cdd21ecc"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Guid[,] { { Guid.Parse("747b3f27-de0c-4f64-bda1-4e4deed50520"), Guid.Parse("fdc2426c-bdf0-47df-992f-9b3b1cc4ffaf"), }, { Guid.Parse("1079a537-357f-4773-8992-87549341b9fa"), Guid.Parse("70cfa49b-c20d-4ba5-8b1e-d71a0cf8bd2e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a59d7416-41d8-41ea-b7c4-c6bc9f18b402"), Guid.Parse("3313c8e5-4f8b-4ca2-92ba-ed3a33f6cd6b"), }, { Guid.Parse("f8902e55-6211-487a-ac61-781f838332b7"), Guid.Parse("93037002-dd86-4e0f-9ff7-203495a27846"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Guid[,] { { Guid.Parse("c4d966dd-97d9-4a96-82a6-acb03ec9cb40"), Guid.Parse("079971b6-dace-46f8-b975-d395a13bf47c"), }, { Guid.Parse("91e6c7b5-7c99-4fa9-bb8d-31317cdf79c9"), Guid.Parse("fe22cc78-4c98-40ad-bf6f-3f13635a78c8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Guid[,] { { Guid.Parse("bf8e14dd-ba22-4423-aa05-2736b5b8b5c4"), Guid.Parse("2d693d04-9f13-421c-90dd-64758a38e37f"), }, { Guid.Parse("322eefe6-f7c9-439c-97f3-e08720642b5a"), Guid.Parse("02239afa-5f7c-4101-a045-62dac1802c51"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7b806d54-1a6a-48a6-8205-0d57832a493b"), Guid.Parse("9e337e33-a1dc-46ce-b823-4ee580c351a0"), }, { Guid.Parse("ec80caf8-3e37-4b67-a061-d086a288946a"), Guid.Parse("d22db709-0d80-4393-970b-e32547184c3b"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Guid[,] { { Guid.Parse("ec2d9992-4b3b-41b1-9d9d-27335aa0fcbb"), Guid.Parse("64f6a88e-a924-4d17-9a47-301db357c0be"), }, { Guid.Parse("ed5f1ef5-d852-41e3-b915-578cb3ebeccf"), Guid.Parse("b3391eb5-0bbd-435e-a5ac-6673b1b57219"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Guid[,] { { Guid.Parse("9000c206-3bdc-4a25-b18b-dbd871510033"), Guid.Parse("b5727fce-6e4e-4280-943e-135e6c1fbcae"), }, { Guid.Parse("462512b2-a674-40db-a98f-477a3af0797e"), Guid.Parse("7d47ab1c-6e3f-4a50-a955-b35996083324"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4564c46f-b31d-40e1-a4a6-51952f79a78c"), Guid.Parse("cc083058-9290-495f-8d8f-40be7ef1f92b"), }, { Guid.Parse("e9ffbbf3-d023-44eb-bd46-9436c350516b"), Guid.Parse("3bf7749e-5c81-497e-abf9-301518cb3dad"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("fa41fb9f-1a45-4923-9c5a-a9b9ab4ac94d"), Guid.Parse("3e0af20d-0b01-42d9-a817-8303c906fd5c"), }, { Guid.Parse("e5438723-5d7c-489d-a866-d50939b571a7"), Guid.Parse("0ab44647-d65d-4440-9b9f-5de6b9683cf8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("ccc9655e-d549-4041-bc6d-2cdb611a8f44"), Guid.Parse("7bf48f57-cdd4-4ab5-b1be-8a470f44ddab"), }, { Guid.Parse("152dcb83-b918-444a-90c3-9a0ca8b851be"), Guid.Parse("0c7ef426-b22d-4974-9f49-429f2fdcec85"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Guid[,] { { Guid.Parse("d65b1d66-5cdd-4ac1-8f8f-8e671d6daff3"), Guid.Parse("e02ff138-2fa2-42fe-aea7-abffc53460f0"), }, { Guid.Parse("5b87676e-f807-4cf4-90f2-d28a1e133cf4"), Guid.Parse("156ed666-672f-4a13-99ea-a1a87169e5ec"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Guid[,] { { Guid.Parse("c35e07e9-bc3c-44c1-ab99-519127ddcaec"), Guid.Parse("092a137a-efa5-4f9f-9fab-2cd42ea76dcc"), }, { Guid.Parse("77fa2bc4-7435-456e-9c5b-77f546a34089"), Guid.Parse("5f99ab10-1703-467b-b60b-526669e74eb2"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b17e70f8-9999-47ae-b799-8c3470e1d8dd"), Guid.Parse("4e7be910-0423-49b5-90d9-417edcde6082"), }, { Guid.Parse("b86c19b5-7e86-4a20-a9ff-9be6c0b7e3e4"), Guid.Parse("c5030e23-4201-4d39-8678-abbad7ed26cf"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Guid[,] { { Guid.Parse("da7daefa-03a8-4f61-84cd-189c12b8a19c"), Guid.Parse("63295aef-0ab6-420f-831c-ae3ac3a2b10e"), }, { Guid.Parse("f79ca2fa-8ae3-499c-8b5b-093b776bc1cf"), Guid.Parse("38f1b5ee-3486-4285-b5f3-83215386e87a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Guid[,] { { Guid.Parse("fb1a39fb-1e01-4006-8d63-b34b2d0cd310"), Guid.Parse("2545b805-a564-4eaf-9e2c-7cc8eeaa39ba"), }, { Guid.Parse("4758e845-f2e3-48f1-828e-d002046edb57"), Guid.Parse("e99b45b8-443d-412d-97ac-d92c79839f08"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9b2e0905-6122-46b3-a1fe-a2b10ae20289"), Guid.Parse("5a8431e0-07ef-4303-9bf9-8335d8bd4a64"), }, { Guid.Parse("7af1d56b-7bd4-4d59-888e-c2f9c125b4d2"), Guid.Parse("c76facd2-497f-4bbc-8327-7bb76a1c64f3"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ae95cad3-4e47-4bf8-be2f-10f67674765a"), Guid.Parse("08e1af5c-d22a-4ddd-a346-c7843aa2ff1d"), }, { Guid.Parse("42837886-6bea-46d0-93c0-5708df77a144"), Guid.Parse("83f442f4-d30c-4ade-9c49-83fa3fbb990a"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Guid[,] { { Guid.Parse("8d3c2064-0629-4efb-a9ea-f34c114f7018"), Guid.Parse("46f8e8c0-9771-4968-b562-8d67b6b5d133"), }, { Guid.Parse("f1d5bd9e-790b-4553-8ac1-773fc9138718"), Guid.Parse("b891b2f0-f4f5-4103-8f46-7f28820a5863"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("dbad7f4e-4eb1-4c27-b0b1-05d10b03c413"), Guid.Parse("7a71a25c-bed9-4a70-a76a-50929459fc0c"), }, { Guid.Parse("041c5d9e-807d-4541-9bef-e6dd617418b9"), Guid.Parse("d03a1aac-3bac-489a-839e-ad2a1d99b34e"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Guid[,] { { Guid.Parse("c9ec912b-d371-4fb3-9dfd-e52806f97fe3"), Guid.Parse("f46660e8-1a7f-49f2-9757-66530bbabe6d"), }, { Guid.Parse("102cc370-2c87-4b9a-b5ae-f6227e50d06e"), Guid.Parse("4e521969-8ca8-4d5d-864b-ad1fd892c222"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("5d717b78-9309-43cb-bc1a-3e426e4f7c5d"), Guid.Parse("f6fe9af4-2150-416d-808e-fd33b760e738"), }, { Guid.Parse("8e862c76-8051-4b11-a157-165eada68fc1"), Guid.Parse("81d5cd82-f79f-470d-8960-0043a8314445"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("97ba825b-2c88-4dba-813e-eedc89019910"), Guid.Parse("af56547d-db06-489a-ba7f-a832fb4403d0"), }, { Guid.Parse("eb83aa17-3e21-40f1-a9da-79b60847266a"), Guid.Parse("7a92e653-b549-4f8f-8e63-00506b282c1a"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("290b2f3d-4ccd-45e3-8c7d-36ff27636ec9"), Guid.Parse("fae4cdc9-9504-4798-b7d0-564d500f6ff3"), }, { Guid.Parse("c80efdac-ba5b-4b7a-aa73-9a327cf0e946"), Guid.Parse("0b6b5c86-34df-4fa2-9af5-a0e2f64fb4f7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("00fc79b3-37bf-4de9-b90a-3c38bf6b07e4"), Guid.Parse("1121798d-c627-4566-82a5-adb1cee9e42e"), }, { Guid.Parse("7c768c9d-7c64-40ae-a04d-721659488b00"), Guid.Parse("bc87acca-7d7c-4bb5-b496-c2a3c419894e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("96ca420c-a456-4cf9-a886-a0661f8508c8"), Guid.Parse("fc30c6f4-1538-4560-a2ba-cb90565c0d89"), }, { Guid.Parse("103b5b62-f6d1-4884-bb4b-c556cc635967"), Guid.Parse("39b9295d-4abb-4747-ba4e-64be7e448bfd"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Guid[,] { { Guid.Parse("8054a687-5927-49e2-8f4f-9bda331ffc67"), Guid.Parse("1a98b801-076d-448c-ba92-f88692d2c5ef"), }, { Guid.Parse("dd1b463f-b8c4-497a-8c09-af1b7078008d"), Guid.Parse("8fa1560f-8bfa-43be-9348-c5642cadbb69"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Guid[,] { { Guid.Parse("8085b8ff-08e0-4271-87c4-6874e4607de8"), Guid.Parse("912918df-d53e-4513-8b81-26d8ee3f8298"), }, { Guid.Parse("17e75f48-e027-4423-9ce8-21aaa0902dc2"), Guid.Parse("355e1b6f-2ae2-4abf-9cb8-5d080af75d3b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d9fc1966-29c6-4858-a242-cec608a0f6a7"), Guid.Parse("df222360-2d73-4c84-9bd3-d828ce2b2641"), }, { Guid.Parse("8053bebb-21bb-48e0-b8d0-97107776e8d6"), Guid.Parse("0efc9004-8ea5-4bf5-9b69-0b4bf8b55ddc"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("c5725df7-23f9-4769-ad1d-638b0dbc56a8"), Guid.Parse("a7666fb0-11b7-41d2-a668-3c367af9896d"), }, { Guid.Parse("2228f19d-2f60-4053-a37c-f0f1e9182cbe"), Guid.Parse("64ffeb40-71c9-4079-813b-b68286f1b9a1"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 138,
    Value = 
new System.Guid[,] { { Guid.Parse("e4a04afc-bcd8-4e9e-8e2f-7d959c37d2ce"), Guid.Parse("5714b149-8283-478e-8f71-fdd17cff5d31"), }, { Guid.Parse("71cb5fa5-2233-42dc-96e4-ac124f1fa5b3"), Guid.Parse("204d43d5-2fad-4ba5-9090-14286952f8ed"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6dec55c1-c48c-4209-b396-ac6ba96dacd2"), Guid.Parse("0be92be7-93c9-42f7-a7aa-2645916a3f7b"), }, { Guid.Parse("ba456387-8547-4960-9498-a3627d1e40fc"), Guid.Parse("6b252982-5e1c-4669-8048-e65e31f93c5b"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Guid[,] { { Guid.Parse("39d51389-f787-44f6-b1bf-4bc5112e080d"), Guid.Parse("2d9d5ac6-6c38-4a33-ae58-46f4f290e61e"), }, { Guid.Parse("c128df95-b760-414b-8752-fd953af9db0e"), Guid.Parse("6086e96e-3ae8-4395-bd79-0ca3e242145e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("03a9e4ba-8595-4697-b995-33a36dd73250"), Guid.Parse("1f6cde86-356b-4192-8aac-01ff3e3e8b25"), }, { Guid.Parse("e69f06fd-df03-473f-9619-fde8b9d874e6"), Guid.Parse("72b317ee-5936-4462-a8e8-c7ea1dfe2f9f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c5290ed3-e2b8-45ec-a127-44a31bc2f1d3"), Guid.Parse("3ca69c38-f586-4f58-bd62-13275ebe6715"), }, { Guid.Parse("bd683fb4-e07c-48e5-8d48-bb6c09b9e66d"), Guid.Parse("993fef70-1cdc-49c7-97b6-f06e3bc84e57"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Guid[,] { { Guid.Parse("5eed66d4-1617-47fa-a084-429e9d2f52c8"), Guid.Parse("97e8b0d1-0ac6-4063-96ca-cd4317c488ae"), }, { Guid.Parse("1f4dd6a0-b71e-4889-aadf-8b290a634828"), Guid.Parse("1563dbc6-ee42-4f10-b3d0-f013cad73a6f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Guid[,] { { Guid.Parse("33734cd4-2cb4-4f79-ac08-3671fd8639e2"), Guid.Parse("7c7c0df0-c551-4412-bf90-58482a11e5cc"), }, { Guid.Parse("394d7a13-f32c-490f-9f82-6ce22ea57508"), Guid.Parse("c0900b90-618c-40b3-b00b-30cf92836c0e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e2b93c99-c64f-4bc1-84e6-586c7e9b609e"), Guid.Parse("bbc83ee6-4e50-42e3-8b4d-0ca74ee14041"), }, { Guid.Parse("22735cab-250a-44bb-8a82-c55259bb65b5"), Guid.Parse("d11ff4f3-4ec2-49bb-8859-54e5d43d4c0f"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("3cabad61-d1ce-4d65-b22b-18357807f2d1"), Guid.Parse("5a75d55b-7e23-4e80-8455-2bfb9b6a0bc9"), }, { Guid.Parse("59769c40-bba5-436b-ba0a-468f6aa64f5d"), Guid.Parse("26ba38cb-5e10-4192-8f5b-e8c4a73297bd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Guid[,] { { Guid.Parse("2e82fa0c-c24b-44e4-8b8a-acd51a15feb8"), Guid.Parse("083fa764-3525-440e-abc9-d2fff3379b1f"), }, { Guid.Parse("c766d5f4-686a-4f50-9fab-f8cfedb69012"), Guid.Parse("921efc46-49e5-4fba-b1b9-ffd411ab5033"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2a336ec1-d5ff-433f-b425-0b910add3e64"), Guid.Parse("6165a311-3746-4741-ad89-de118be3e9c5"), }, { Guid.Parse("abf0b6ab-b40a-4b7d-8427-fd18721e4abd"), Guid.Parse("fe0b8703-c769-40f8-9258-e3eb2d660ecf"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("564b254e-594e-4a52-acbd-266df578afdf"), Guid.Parse("bb5a2970-8e2a-4981-9401-986fbe4bfed6"), }, { Guid.Parse("77a175ea-39ce-4d7f-b148-5851cc971a93"), Guid.Parse("a6745fd9-99a9-433c-b7ec-99a70652f1de"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Guid[,] { { Guid.Parse("088e965c-6199-4f2d-8db2-aa407c97151f"), Guid.Parse("4d64c449-f68c-4b1c-993d-066be22708e5"), }, { Guid.Parse("70eb8408-353c-4d47-8619-81c1c135deea"), Guid.Parse("8fcce7cf-6a5f-4ce8-a24a-4bbe1131dceb"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("4c526d19-3c30-4220-ba13-078f8f8d4174"), Guid.Parse("eeec14f1-8d16-4611-89ff-e889455b8b1b"), }, { Guid.Parse("7ad1d195-9545-43bb-a2ed-4388e4dceb89"), Guid.Parse("a09c0938-efb5-41c6-99b9-f5d65e86788e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("234225ba-5387-403a-8118-5963c294c6a1"), Guid.Parse("d53b037e-18b2-4a2f-abb7-13ca34f52fd3"), }, { Guid.Parse("b212f61b-967f-4c0b-adfa-d964dcd00386"), Guid.Parse("f16da92b-2d85-4067-aa47-540c25c00a7d"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Guid[,] { { Guid.Parse("057e9f39-a609-4813-ad10-b18466807d5e"), Guid.Parse("06f88289-4c90-4355-9538-dc66c8402899"), }, { Guid.Parse("1bf36ff4-2cfb-4565-af32-f86670003222"), Guid.Parse("9338a6ea-033b-4943-b935-7cb29855f646"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("08908b14-d6ea-43e6-8eeb-e4c34eca77d4"), Guid.Parse("78098a54-724e-4117-bc63-72e5d0aca8a6"), }, { Guid.Parse("73a64419-1147-4228-9d58-a2ac00f3f5ef"), Guid.Parse("68459ae7-2825-485a-abe8-ec2c4aeaa462"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7b1c062d-fc1c-4bee-bad9-de7e81430f82"), Guid.Parse("4c72b36b-8e23-4622-93eb-2f88516324e6"), }, { Guid.Parse("aff14595-311a-4f60-bb2b-73c7d4927895"), Guid.Parse("5b99cb08-6fe1-4775-829f-fc38f4871b76"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("69ce3060-0aa2-4800-bc65-6e3dd1b323bf"), Guid.Parse("ee76bf8b-70b5-46c9-af4a-7054b0c85c4d"), }, { Guid.Parse("64d7754e-59e1-4b25-bfb6-5826c077495f"), Guid.Parse("3d5bfe1a-9897-4b91-9a5a-dfa7b9333ae7"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Guid[,] { { Guid.Parse("8cb77e22-cb92-4e6d-b307-efa7df67aaea"), Guid.Parse("e928b48f-1c6d-4e32-b0ed-f251bb2c67b0"), }, { Guid.Parse("fa53ccde-9856-4eb5-bb7f-c99d01e7e763"), Guid.Parse("333ec25f-9242-4468-95ac-5acda2625cdd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Guid[,] { { Guid.Parse("6ebc7947-87de-40ae-a63d-67dbece22310"), Guid.Parse("b801940f-716b-4a6c-94e4-14ac09df05e6"), }, { Guid.Parse("0e38256d-645e-4fa2-82d8-d368f57b07b1"), Guid.Parse("8c0131ab-94f2-4a23-b4d2-df330a0a6473"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Guid[,] { { Guid.Parse("bfde7ede-0093-4d50-8bbe-8567bc337add"), Guid.Parse("2ed670eb-30df-4bd5-ac62-93d6b805b85d"), }, { Guid.Parse("e8277dd2-a923-4ae2-ad94-b8448e437b13"), Guid.Parse("d6dfe11d-649e-4a3d-b192-3d9b71d937be"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Guid[,] { { Guid.Parse("46bd3104-21cc-46fb-b0c3-00d7a9f05671"), Guid.Parse("2baab20a-1979-4989-be58-3c4d58a72a42"), }, { Guid.Parse("6a2852a8-9f28-4653-b816-b36857a0f4e2"), Guid.Parse("507a1d40-cce5-4412-a674-11d4f9ca2bb7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f8cbdedc-090d-4753-bc4e-fb41ce63159d"), Guid.Parse("9282a802-6988-4338-a8d4-9207e0f24770"), }, { Guid.Parse("fb67e50d-c8e4-451b-893e-d020b24d0997"), Guid.Parse("0848cbd7-f903-48c4-a2cf-2a23c3f07d45"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8e68c078-ad60-4b16-9d1c-45751cd32da5"), Guid.Parse("7a78aae8-56bc-4e00-b3db-2764a521efbd"), }, { Guid.Parse("e16760b5-d03b-47e5-9114-be13a031dd50"), Guid.Parse("06d235d3-e0ab-45c6-9edf-36f4356fe13d"), }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidmarrayd2e1m(
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
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
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
                    await ((IGuidMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.guidmarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
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
                    var models = await ((IGuidMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

