

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
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("a5f92c7d-b131-4495-b0b5-f2035abe622d"), Guid.Parse("df2df723-1bf2-4c5b-847f-b47256266af2"), }, { Guid.Parse("fd5c503b-614a-44fb-9976-204ec8fae952"), Guid.Parse("242468f8-b2e9-4598-a8f5-85a7259fa46f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Guid[,] { { Guid.Parse("4521b0fb-aa1e-4386-be76-ec9ba1c273de"), Guid.Parse("6b00d901-6cce-4694-aecc-cafcbf980bc3"), }, { Guid.Parse("313fab9b-0fe9-4bfa-aa56-14db9c603bc3"), Guid.Parse("81700dc9-ec07-41d8-b71f-6750eaa14858"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7c1059bd-0eff-4a30-9b57-2e6cc248885b"), Guid.Parse("1ec49c42-ffad-4eec-b3f0-f35b3e1a3b23"), }, { Guid.Parse("8a06368a-91b6-4d75-b1ef-bbd77641a9e6"), Guid.Parse("0ccef289-da62-430f-876c-29119d67f16f"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Guid[,] { { Guid.Parse("67055195-8b69-433b-82a8-09cca5d43ac3"), Guid.Parse("2d8c84a1-e320-41d3-88d4-f23051828b3a"), }, { Guid.Parse("b427471d-43fd-4249-8c54-6c0d8c924bc4"), Guid.Parse("8761c026-e5ad-49c8-b15a-d92ed530842c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("7176788c-e153-4491-9377-c4b241cd06a4"), Guid.Parse("a6d50465-2683-4208-a20e-95705e59a1ec"), }, { Guid.Parse("411d9870-7e61-462f-8a7c-c40614cb6df8"), Guid.Parse("542f0c14-6a3b-41c6-9cf7-b5bb3d6e0b5f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("63df1c06-8b1a-4aa1-a57d-126ce41ca8d2"), Guid.Parse("d51f748b-4504-429f-b84d-3ff44694465d"), }, { Guid.Parse("2718e6dc-4629-47a3-be43-0035fe07dfff"), Guid.Parse("abdb577c-397f-478b-9bd8-80f5777656f8"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("0cc42dfb-7720-45dc-b16b-961becb689cb"), Guid.Parse("c192d2ca-eff1-4ee9-8d3a-1f3a9947332c"), }, { Guid.Parse("0d35d499-6526-4068-ad83-291fe0443028"), Guid.Parse("55e3b725-2df9-4fcf-9092-65c4c5842eab"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("bcf7dd2a-78c7-4228-83c9-f2c180066db7"), Guid.Parse("c3c343be-3d4b-433d-9fc5-b7e35352733f"), }, { Guid.Parse("e7b4d905-81e1-45c4-b891-007ea08098c0"), Guid.Parse("bcae320b-4ceb-44f4-a278-84159799405b"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6d9e8aac-15e6-4b17-b317-9fa8ceb837b0"), Guid.Parse("db765ae1-367e-47d2-a83a-32bada83aa8a"), }, { Guid.Parse("2287ee85-7770-4733-bb11-4019451961c7"), Guid.Parse("eb093780-d385-4c86-821f-f2ca6ddc7f65"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("f9ae0e82-1ae9-4a73-8391-4c9c1b1e3483"), Guid.Parse("540cb2e9-0cef-428a-93b2-6b6f0184bf69"), }, { Guid.Parse("8300b0c3-4b82-4862-bdc6-7bea8dde5688"), Guid.Parse("82482b9a-8b9c-43ed-ab27-8430ac75f689"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("12307710-1654-47c6-bf4e-39c7ca9541b9"), Guid.Parse("ee986d81-5019-40e1-80ba-e88864af74f1"), }, { Guid.Parse("95c4f711-69d8-4fc2-9713-3e516a481f7d"), Guid.Parse("094e57a3-805d-406d-a0ba-49292c0c26f7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("43dbc84b-5f60-45cb-a46f-a1a105a70a04"), Guid.Parse("e155c19e-e69b-4b2d-a298-f98a8bcb2bb6"), }, { Guid.Parse("26776f57-506e-42a4-b413-2371e8b20588"), Guid.Parse("9b276044-4de4-4128-83f2-bfbcc10c8021"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("ef3f5a0b-a3db-4ecf-8670-82de3791b439"), Guid.Parse("80619bf4-cc6e-47ff-b802-ec26032d140d"), }, { Guid.Parse("0de4c731-9bfb-459b-9445-10a9c54e1936"), Guid.Parse("10db8f76-f827-4a07-8407-26afc2633276"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("14763705-ebb7-4942-b06e-a0c992326a0a"), Guid.Parse("41af8ff0-de3f-41bd-868d-da6eed3dd6fb"), }, { Guid.Parse("692d48ed-7b19-43aa-8eef-881615feb7ff"), Guid.Parse("dda28055-a4ef-4fd1-8751-e21470b9d2c7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("539d2c1e-aa2c-4c72-8e88-6fbb9a407a4a"), Guid.Parse("a05b9b90-98c9-4d07-9d9a-091a0dd90ffc"), }, { Guid.Parse("ab952dd4-ac19-4131-89e1-075725942112"), Guid.Parse("8fe8ffb6-f9e6-44c6-9354-b45f5ae36db1"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("81eb01d5-d0b6-4312-9dce-e7412b5c9274"), Guid.Parse("d0c0342a-dff3-44dc-98f6-1b9c5f05f113"), }, { Guid.Parse("cc6d2965-6106-4089-9d43-9bb55eb82a44"), Guid.Parse("fc9e816a-5290-4e8d-95ac-1c53186ab0e2"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Guid[,] { { Guid.Parse("0390cddd-6cd0-4037-a818-6367f69a895b"), Guid.Parse("37ca7c1d-6825-4a76-84a5-613de2e26ba6"), }, { Guid.Parse("ba25f0cf-b782-4e3a-a799-99e3762bb087"), Guid.Parse("2b7ef3aa-4a58-44fc-b6f6-2496f2411a4b"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("3172bd7c-58c4-4495-aadd-02a8731506b4"), Guid.Parse("16bced55-e82f-4786-b104-39d40d1765b5"), }, { Guid.Parse("e1b015cd-c78b-40a7-8566-347a9b690a8a"), Guid.Parse("451258be-33bb-4ad7-8a05-de1258babc3f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f00b265f-64b7-4ed1-a11a-0222ce200ae6"), Guid.Parse("62280d47-bb3b-486c-906a-e9fc25a3f0e3"), }, { Guid.Parse("70f00f1a-81c2-45a3-91cb-1f4285e0daeb"), Guid.Parse("c9aebdd3-1626-40ba-8492-1b22be6da9e4"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Guid[,] { { Guid.Parse("cff4a79a-f9f9-41f4-9a26-6342575e8d4b"), Guid.Parse("d667eea2-ae12-4698-a983-4bd70dc74ff5"), }, { Guid.Parse("11157509-815f-406e-8037-f79f6e5fbf2d"), Guid.Parse("ee128726-ec63-426f-8ef8-b53d5c3e2f97"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("682825d6-2ba1-4ab7-bf22-28da5613d580"), Guid.Parse("a3f06c3a-b64c-4f4b-a587-20c1637a8ac7"), }, { Guid.Parse("70e5d1a6-ba8e-4a3a-9eb0-5d2967ae55cc"), Guid.Parse("471ea0c9-7ec5-4afb-b8ab-24d891f70350"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e45669f5-6cd3-4e3d-bbf3-cf67ff4f97eb"), Guid.Parse("6aae96e9-f1b5-4d00-8b39-2c3f8bb1a860"), }, { Guid.Parse("97d9c196-0a7c-4981-846a-d2df7369590d"), Guid.Parse("81b9ba5e-8820-42d3-bac6-3a6234326bca"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("406d8566-3605-4685-85da-dd12a8a3e7c6"), Guid.Parse("e933f0fd-e35c-4572-af52-4d028acb82bc"), }, { Guid.Parse("17f894aa-f637-4259-a2f8-4f744be1cb66"), Guid.Parse("8b2cbf2b-1e26-4701-b0ba-f87e87a9998a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Guid[,] { { Guid.Parse("3892d627-6987-4d39-855c-79b2ddea8d9b"), Guid.Parse("e394453d-2974-41c6-9100-dc6d71a75905"), }, { Guid.Parse("5f318bae-61a0-4648-8303-5be1aca328f3"), Guid.Parse("09b55c08-035c-415d-bcb2-29132a2c6131"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("80ae3d20-1e49-460c-a780-3b544bd0b6d0"), Guid.Parse("4dd9a9b0-23ce-401e-94ea-56e0a4b31f1f"), }, { Guid.Parse("b6d6f5a3-ce65-4e1b-b3a3-fb2d5185f266"), Guid.Parse("3f684d88-5b60-4064-8b1c-ae050a3db626"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("64315b69-b3ec-413d-80ba-1ddd9aa1f692"), Guid.Parse("3b2d0231-4a69-48ed-9633-d643be94cb5d"), }, { Guid.Parse("06c99630-8e0e-4d50-b6dd-3db29903f44e"), Guid.Parse("8b4db0d0-804b-410e-ad6a-907aaca874e7"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Guid[,] { { Guid.Parse("341b13b1-266c-47ce-89a0-6379db4c182a"), Guid.Parse("2b3ff557-0513-40cc-af53-8a4fa82e33e3"), }, { Guid.Parse("c46f4dbf-2606-449f-8439-cfe58a26183a"), Guid.Parse("90301796-318d-4d0d-b1c8-2ea55e0508e3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("d79b07a2-2b18-42e4-beb7-666f183273c8"), Guid.Parse("8f201ff4-3fa1-47c6-ac2d-475a5322e72f"), }, { Guid.Parse("451d15c7-07ba-424b-b3c3-5bfcd24372d2"), Guid.Parse("023cc7ad-b9aa-4326-a547-9340d0ed7fda"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0c1bdb4b-e4ab-4472-8dae-ab84e565836a"), Guid.Parse("b95af1dc-8a87-4682-a71e-2854297de194"), }, { Guid.Parse("d1b782da-9cd5-4a79-80e2-d98a4374b8df"), Guid.Parse("97c588f3-5bb7-458a-bd95-fd95337ef152"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("afdf9197-6b74-4db9-8de8-4ac96d46895f"), Guid.Parse("d48698ee-2d7d-4232-bb4d-b8adac02826b"), }, { Guid.Parse("bd14f291-b1ba-4ca8-8146-a1615fdc1631"), Guid.Parse("1ef6c2af-0438-42be-a052-fb3eabf10fe7"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("68da3e6d-1ad6-4c55-9995-27fd40553cb1"), Guid.Parse("a02d5adf-2e2e-493f-95c0-a86e5fdca32a"), }, { Guid.Parse("f32ee490-8c42-4b51-baca-fee70783fe4d"), Guid.Parse("aa70785b-0a63-4d1f-868b-eed541b8e6b0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("c5908791-7ea6-4135-966a-559636b281a8"), Guid.Parse("b6fa77d1-7794-47b2-9d52-a1d325bb9a92"), }, { Guid.Parse("cbe1f3c9-1300-4dd7-9b6c-ff4018927ff4"), Guid.Parse("f0a20174-4bc1-46ae-82f3-6a57e9c37b4c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3c520546-22de-47c6-94f8-30d8661a09a2"), Guid.Parse("8f680499-21ca-4e7d-b4c3-a2cc879de162"), }, { Guid.Parse("d26a6d25-24c4-4125-8e02-0ecd53a9bcb5"), Guid.Parse("9b82407f-4973-4c94-88e9-2d6300e9f85d"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Guid[,] { { Guid.Parse("dcbcbfa3-670a-4ba3-a883-7f28b6147278"), Guid.Parse("6c458f09-0756-4b72-9407-3c7761b4817d"), }, { Guid.Parse("ad9760dd-fadf-4c83-87ea-e231215fecd7"), Guid.Parse("8732c0d7-0dcc-452b-b862-6e813b897386"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("e6afe388-5160-4509-ac89-6c94653b8e65"), Guid.Parse("afb56cda-3eaa-46cf-a855-b45ff8137dc4"), }, { Guid.Parse("1b13663d-c787-42ce-b753-53a8b66c9fae"), Guid.Parse("a0ec7da2-dc2d-438b-9077-f8eec3b3ce12"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3355734e-db02-431f-9906-d89681221095"), Guid.Parse("d4a79f40-28f1-4910-92ee-f1a377230002"), }, { Guid.Parse("34a40d91-c3e7-4cd5-824c-7943108a944b"), Guid.Parse("4fd8615a-3255-4d72-8962-e978943de298"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("8004f4be-d58c-4f79-be08-68233af91112"), Guid.Parse("5e70dd6d-b97f-47d7-8b45-a434cb394597"), }, { Guid.Parse("01e8deb2-a606-4e50-b168-7726112c59ea"), Guid.Parse("ac2d3ae0-ee44-4afb-bec8-8b0deaafa47b"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("3cd73874-d538-47f9-94af-ad9d6e903d6f"), Guid.Parse("94d2c7b6-5675-4248-88df-deac9d21a32d"), }, { Guid.Parse("47c1b3ac-ece9-4fcc-98a2-2908a8058037"), Guid.Parse("e64d6fa8-7ecc-4f63-ae94-53b360a9e65c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b7e88c3d-fdf9-4aed-b88c-fa13b01f1963"), Guid.Parse("ca5b4056-1efd-467e-8d6f-55cfdf3b71b3"), }, { Guid.Parse("8723ea08-938a-4cb6-9cff-fede8f33d037"), Guid.Parse("fd619fb3-ce7a-43e4-b843-7ed01b637497"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Guid[,] { { Guid.Parse("1491ed27-6540-4f43-9560-0764fc7881a7"), Guid.Parse("03f1ca1c-c370-44c5-9b99-d57b0696ec00"), }, { Guid.Parse("d19f6fbb-f1d3-496e-9317-9a895c545709"), Guid.Parse("4397eb01-a7dc-4b6d-b931-20b38c66a5da"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("1efc79f3-a769-47c7-a472-64c20b10b720"), Guid.Parse("f82723a4-f5af-4cf5-83ab-be2b13032584"), }, { Guid.Parse("1e4fe885-ce2f-4ae3-9ed0-c396454c66a1"), Guid.Parse("5cbbb537-00f2-449c-93ae-e517f5dfc6c8"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3bc6ce04-a543-4c17-85c0-111aab0a2543"), Guid.Parse("07633265-6e04-4934-8923-7735ab0f5914"), }, { Guid.Parse("f8a73952-cfc8-4d97-b2c7-cdd82329862c"), Guid.Parse("60bb13f3-0fe4-419a-9829-a72d70d43dae"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f9cee537-9dfb-465d-a6c7-a43422a79912"), Guid.Parse("13b3248e-d454-475b-a6b9-a65379a33e2c"), }, { Guid.Parse("955457dd-d417-4e6d-a9e1-fc4e6c1b38f4"), Guid.Parse("20bc018d-84bc-46a0-9537-a8790e33d1cb"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Guid[,] { { Guid.Parse("427c28ea-4859-4d51-a6ad-bfc068f9fcb2"), Guid.Parse("08852314-0ac9-496d-b2f5-3b75d5210700"), }, { Guid.Parse("4bbc6df6-bf39-4359-8fd7-7d31d18350fd"), Guid.Parse("7099c9ad-91c3-4e2b-9930-1fbd309742b0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("9c3be198-f559-4a1d-87e1-cf662a5ee8aa"), Guid.Parse("27bc816d-3eb0-43b5-acc6-2ed02c8683c3"), }, { Guid.Parse("9413d680-33f8-431b-8849-eddaa21fa741"), Guid.Parse("293c78da-63fb-4bb8-94bc-dba577ebc518"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("6923dc34-433b-4fa0-97f9-e3b050399cca"), Guid.Parse("5b361eb2-ff29-4347-86f4-4f60ed34d56d"), }, { Guid.Parse("48862eaf-fbad-4d6b-922c-bf7f62745ef6"), Guid.Parse("50aa18ae-971c-4cd9-ad29-7dc709e29f76"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("14da6eec-abee-4c98-92ea-44a1c8383a48"), Guid.Parse("092aa649-d296-4d95-9beb-f2fec6167246"), }, { Guid.Parse("8161d52b-2662-421d-af18-c555bc7a3847"), Guid.Parse("f2817fd3-fa71-481e-af32-cb6f32f6163f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("538122f1-cd94-42ec-abc5-470e72cf34f2"), Guid.Parse("82699545-3b2b-42b1-a65b-d1a5365e1e7f"), }, { Guid.Parse("04c83f7a-dccd-4a7c-b6e2-b35a1cd9ffc7"), Guid.Parse("f5bccda2-82cf-4839-b583-f20f0915aa67"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("1154ebc0-5fc7-4a76-9a8d-cdee40a9c636"), Guid.Parse("f5ec992a-24ed-458c-b455-85a12785e9b4"), }, { Guid.Parse("d0a48ac2-be2a-472e-ba20-cbe1c87c33cb"), Guid.Parse("d1d665c4-318c-4ef8-ba54-c2b4d7834fb7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Guid[,] { { Guid.Parse("43640feb-cd84-458b-a846-07b15069bec2"), Guid.Parse("ec4d0024-5f87-4f7e-bfd2-e55cea3eb18f"), }, { Guid.Parse("01dc4da6-fb00-4acf-b0f7-02c9af51c677"), Guid.Parse("a2490a10-da1f-496f-94ce-96f7700d027a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6868ced3-f0d7-4018-9b69-80189fe20348"), Guid.Parse("5cc002c5-9987-4de7-8999-07e4d2c2a084"), }, { Guid.Parse("5c32ab25-7c95-4569-81e8-4e67d468e162"), Guid.Parse("631d23f1-3924-4b30-8c9d-ab3ffa96fdd2"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("34e1f9e5-f9b8-4304-9286-7a0884336358"), Guid.Parse("c762b535-d52d-491b-80b3-c5136f666aff"), }, { Guid.Parse("a6e4b7c3-a31a-45d8-8786-a9998f21b864"), Guid.Parse("a4434cb5-8c83-4e8a-9d65-bda131773407"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("663fe9eb-3634-4349-8c1b-cc229fb80589"), Guid.Parse("65ace49d-6978-48cb-8dd2-b684a3595e84"), }, { Guid.Parse("b3e5c132-98b2-4a01-ae5a-c991ccf5fc32"), Guid.Parse("08cc1182-e440-410b-8680-fdb415b690c5"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("d9ff565c-a7f8-4aad-b711-71264c0ddc30"), Guid.Parse("92448656-19f5-468b-995e-97544a08f51f"), }, { Guid.Parse("561349bd-c9e8-4533-a443-9a87ec30ab41"), Guid.Parse("df38a346-dae3-46bc-bcfc-451309d0ea16"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9ae2859d-2600-4f0e-9345-c64a53022141"), Guid.Parse("bf7f8956-ad93-4cf3-ab04-99147efea05b"), }, { Guid.Parse("ac546a72-0597-4242-8fa2-62d4e3c2ba91"), Guid.Parse("054bc4d0-7961-450b-affa-18b8dd3bba15"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { { Guid.Parse("7afddae5-f1be-4111-9603-a4b5e8416a53"), Guid.Parse("f166a17a-c110-4e95-9d94-803b555f8be0"), }, { Guid.Parse("20f1dc36-45c7-47b2-872b-8fba1f090448"), Guid.Parse("ab07d616-e09e-47de-8949-f1120027ce06"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("5e9759f8-75d8-4b2a-a9cd-eb36f41ee0d3"), Guid.Parse("b7ae04c7-a785-4293-8c2c-f81f96d80b24"), }, { Guid.Parse("0f69a37d-4103-4630-8eb8-17221e54fb71"), Guid.Parse("4471534e-fa64-4aa7-ae27-957ba68f4845"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("919e05f3-c2f8-4dc7-b367-94421fb841e1"), Guid.Parse("52c929d5-5e87-4430-a6e1-dd3b96e8fd5c"), }, { Guid.Parse("6e269861-923d-40ec-bf63-95c09ea8525b"), Guid.Parse("ad598bb4-0e73-406a-8857-1f6c6c870ff9"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("fbf643d9-c144-40bb-b21c-e2d6a5093968"), Guid.Parse("2618a0ad-3afd-46a0-80b0-7b3b43289590"), }, { Guid.Parse("5a0a8d9d-778f-41ae-953c-afec7545136e"), Guid.Parse("240db7e7-d0f6-4288-8ff7-110b1fb98304"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Guid[,] { { Guid.Parse("3705f06f-1e36-4755-80c4-905ea6d5d930"), Guid.Parse("8565fc58-af90-485f-b972-55b93fcae949"), }, { Guid.Parse("54e85603-f87d-4e0e-92a1-2a5a812eab29"), Guid.Parse("da1c6403-d843-4975-9e22-23f5358cfdb9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("cac8d2dc-1664-4586-8b1a-a03a1acacbf7"), Guid.Parse("3b4886e7-7c60-40b3-9c37-7ad6fccd52fa"), }, { Guid.Parse("11985065-d21d-4254-88e1-11dcd04ee707"), Guid.Parse("6caa6b31-b6a5-4aaa-8dee-ea653d2341b3"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e7fbb4e8-740c-47ed-b1ac-b42b9fb15ed4"), Guid.Parse("05ec69ee-d53a-4104-a1b5-e7264354f188"), }, { Guid.Parse("d9492cf1-ab4b-4bd7-bf61-b48359bfe8e8"), Guid.Parse("72328080-fdfb-4203-918d-366462238b23"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Guid[,] { { Guid.Parse("6e72fcda-dd92-4582-97e2-2998142ebc0b"), Guid.Parse("91f086e5-317f-4248-89ee-5b76b2c5f058"), }, { Guid.Parse("b8678b51-c848-4caf-b0ff-1ff0a511dd1c"), Guid.Parse("2e97ac82-39d3-4d47-b669-4dc064175a31"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("11649b9d-5205-43e7-b781-630ca706c6eb"), Guid.Parse("fb30e7c8-a3db-4e17-8740-fbb132c83ca5"), }, { Guid.Parse("cf6c1a54-72c8-41ef-8970-e5ad0488e314"), Guid.Parse("c7152b8a-26fe-4bf8-8bf2-37782bcaaf0f"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e03050ce-fed2-4532-bfa7-c58259d41111"), Guid.Parse("d352fc5b-6ac9-40cc-93be-608bffac2800"), }, { Guid.Parse("5cf5d8d8-5964-46d9-aa34-04372f023772"), Guid.Parse("754fc1e5-5119-4436-ac03-cfd3d415ca9f"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Guid[,] { { Guid.Parse("f98457eb-c45c-450f-a193-e14987a6706e"), Guid.Parse("891e1e35-c3d2-4dca-b480-9d6e64d0fe6b"), }, { Guid.Parse("ace5176c-bcf7-4ba7-baaf-a6febaa4bdf3"), Guid.Parse("fac678da-49a7-4877-b36f-d99cd6ba733f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Guid[,] { { Guid.Parse("a1d5ebeb-1871-4e17-924f-03ec205ee490"), Guid.Parse("387afb06-1abb-40a6-aeaa-5710f7ee500e"), }, { Guid.Parse("438245df-7693-4d9f-bb21-2080e968033c"), Guid.Parse("2a7e1e96-6b9d-44f4-8552-708cc1f78df2"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d12b7ce1-ba78-432c-b5f4-034d408ce4f4"), Guid.Parse("36574c4b-4304-4a4a-bc6b-6ceea9635e76"), }, { Guid.Parse("54158bb4-5bf8-47f9-b027-bfd46989040d"), Guid.Parse("55827365-b4ca-4125-95dc-f2d55bab71ea"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("87f089c0-69ef-4224-9edd-6b420901f4ba"), Guid.Parse("505ffb54-d5aa-4659-81d0-5ee9ecce9bf8"), }, { Guid.Parse("9e1ab1b8-1626-44ab-bc96-1b10b9eb4341"), Guid.Parse("f720909f-ace2-4c92-a7e8-b9cb8300ec71"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Guid[,] { { Guid.Parse("a5c5211c-e87e-41fd-86d3-11b36ed8e6c4"), Guid.Parse("44c7848c-9afa-4f74-a2ad-b378c3c58423"), }, { Guid.Parse("7798e21f-6846-4e5e-bba5-39efe0be268c"), Guid.Parse("4cce8545-b38d-4568-815f-9572a902a52c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Guid[,] { { Guid.Parse("835901a7-1be6-42d4-8d9f-bceee99d17de"), Guid.Parse("4658d7c4-2c90-4b7f-af00-e2ed0dd5fd96"), }, { Guid.Parse("f5b26aeb-34b6-4175-bdb5-efa7f19d08a8"), Guid.Parse("3942bcde-0def-48e7-9837-c1cd50213c96"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e4007003-3105-4b1a-8310-ba5cc909e3ae"), Guid.Parse("ca8ef685-eacb-4cf3-9a83-928ae39dc244"), }, { Guid.Parse("a4bd8aeb-cc5c-4013-8b07-1c3a736dbba2"), Guid.Parse("9386179e-49ab-4aba-bcea-2f2e31ece9a0"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("fd0a947c-781c-43c7-b427-87b6f4c92177"), Guid.Parse("de18c923-0f5b-4e13-86c0-b4da3fa40c61"), }, { Guid.Parse("a8c23477-fb8a-4777-a6a3-7b26277c478c"), Guid.Parse("1a93d0a4-7676-415d-8a6e-82b6c51ec95c"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("2843bfac-1c65-49eb-b871-44d86bb94fd3"), Guid.Parse("2f28c717-b79c-46b6-ba08-dc1c7f36ba00"), }, { Guid.Parse("7f729d86-0fe4-4acb-a6f4-3e6c6d5c17f4"), Guid.Parse("0c7e0808-f26d-45dd-baa6-fe6331dfe39c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Guid[,] { { Guid.Parse("dc547cce-aa8b-4835-90e1-e632fc95d603"), Guid.Parse("e4abb323-926b-4ce2-b21c-d51b1308c83d"), }, { Guid.Parse("d14aa890-78d0-47e7-8a04-b7e528c27043"), Guid.Parse("aa99d547-7f3d-43ab-a984-f002b038c47c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Guid[,] { { Guid.Parse("506d0185-369e-4a73-8fc3-12af4439bc99"), Guid.Parse("ded73397-3706-4307-b8e4-515bdd2b445f"), }, { Guid.Parse("40fb18e9-70a6-437b-be05-bc9a7b9f2a92"), Guid.Parse("52ad5539-3414-4f47-8e6d-a1ad935b9f4a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("353e3e4e-bba5-43e7-b9ca-c08804841379"), Guid.Parse("72155890-1d09-443c-a6f1-cfc070e6575c"), }, { Guid.Parse("beb4c46d-e0bf-4b64-bf5f-4ee70956676f"), Guid.Parse("8826133c-534d-4073-a874-d00378d61312"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("fb9ee65c-eb70-47a2-aa5d-3b4fc48763a0"), Guid.Parse("b81ceb7d-b034-4ded-8f93-d63a8997fb10"), }, { Guid.Parse("3d837e0e-ff9a-46eb-80ba-b273710fbc8d"), Guid.Parse("ba35422d-91e0-4af8-9d93-625943828a3d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Guid[,] { { Guid.Parse("766952bb-5bfb-4603-beb9-b6892b46fed7"), Guid.Parse("9d4997e8-998b-4c67-a29f-6f3d2e832c54"), }, { Guid.Parse("99b95fce-cb95-42c0-9bdc-14a60bd0368e"), Guid.Parse("2d595bbb-1769-4434-9506-8b292e784d70"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a760819e-71d6-4411-9eb3-abde77b45235"), Guid.Parse("a42822c4-a2b1-445e-9f60-efb04dff078f"), }, { Guid.Parse("7a790f55-a483-4fa7-bfd6-e2ff7721abd4"), Guid.Parse("eb4b4817-c35d-4605-a4f9-0cd959f03630"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("626fe72f-2f9e-4fa2-8d4a-1d906ecaebb6"), Guid.Parse("85efb9ea-e5f3-471c-b60e-8c87d7514066"), }, { Guid.Parse("b8d3d8c7-bb24-4f48-9bd6-c0a4feddefc6"), Guid.Parse("d4b7fbb8-427a-49a0-9a2d-cdb41c9e919f"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("3bf37d35-d1e1-4656-920d-aa21d3a74aa0"), Guid.Parse("f5d09103-fe9e-45df-b860-3941127ca7df"), }, { Guid.Parse("b1b9bf09-1d05-46ea-80f5-c96f4215c081"), Guid.Parse("f3067910-c8ff-4653-b3e1-f7c9b0459369"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Guid[,] { { Guid.Parse("dec5456f-70c1-4ce6-8d7d-0662ed04fcdc"), Guid.Parse("5beace8b-0b48-4a07-9797-33bf8a9f59f4"), }, { Guid.Parse("d4d0cf63-a383-43c6-a353-a3ea581b5000"), Guid.Parse("349d2d52-3973-4538-a19a-33399772c9c4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("dd002d5a-685a-4ec0-be97-6a5a5b476429"), Guid.Parse("2c3fb832-dc25-483c-b257-4234bb605c69"), }, { Guid.Parse("17bfa98c-15c0-4a8f-898a-06091a7d046d"), Guid.Parse("03988385-f1ab-461d-8dde-fc3faf1011ef"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e12d6457-f05d-4f69-8201-8e40557a038f"), Guid.Parse("91cb6c11-aeb9-4a00-be94-d343ac8fa9ad"), }, { Guid.Parse("85efc796-0437-4c2a-a844-2e2885b26424"), Guid.Parse("bc490203-8055-4219-af9c-983f5f924d38"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Guid[,] { { Guid.Parse("0c7b1839-83e7-454c-b4f0-ea399dd1a7fa"), Guid.Parse("f0266e7e-056a-4438-9638-ca647a45d0a7"), }, { Guid.Parse("02debb7c-0306-4b82-b875-c975286692a6"), Guid.Parse("03220586-a313-4529-8f2f-0fd14496ba6a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Guid[,] { { Guid.Parse("34029d2b-d5b0-4342-9577-b7d009734c0d"), Guid.Parse("d90e558f-1ac9-426a-8191-b59cdfa768ec"), }, { Guid.Parse("341b861c-c748-4540-bc4f-c289dbad13dc"), Guid.Parse("9f2b1c75-4580-4175-990e-53ffea424a2e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("35866914-f91c-4ccc-994f-d2f09d55160d"), Guid.Parse("f80e536c-eea3-4daa-a8d6-0b861c097a33"), }, { Guid.Parse("8af22e81-ba3d-4ff3-a1ff-f0a0a867684d"), Guid.Parse("4ab37e0c-743e-49ad-bded-4b203ab34579"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Guid[,] { { Guid.Parse("29831cfc-7614-4fe9-b512-f03ec328c21d"), Guid.Parse("c73355a6-0aa4-414f-92ae-9dcd57380910"), }, { Guid.Parse("29c2c448-2836-4873-8ad9-87c2c78bed36"), Guid.Parse("073a6743-e2e7-4d58-8b7b-a34d09a1ef30"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("a424062a-9772-4425-8dbb-8df8c2ff1be4"), Guid.Parse("64611c83-0b3b-49cf-8026-4828c1b98604"), }, { Guid.Parse("cd786593-07e8-4071-adf1-cfe5e0e2598f"), Guid.Parse("de0f580f-8049-4fe1-a9d6-e7e9b66df5d4"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Guid[,] { { Guid.Parse("07b68602-431a-4e81-8471-09293aa7bb5f"), Guid.Parse("0295d870-44e7-473a-8820-e4716b15b9ee"), }, { Guid.Parse("e07813d3-817f-4909-bbfa-fc31b8476285"), Guid.Parse("41401d71-472f-40d5-87e1-98af2c7005c1"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("3de74c45-9cbd-4417-871e-61e02562c602"), Guid.Parse("497f113a-7646-49b9-b4a7-33505b8fbe22"), }, { Guid.Parse("2c498295-5647-4ba9-a12e-c4559bf33342"), Guid.Parse("da51cadb-043a-44ce-800e-a106c4015e28"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("91df0777-40cb-44e4-bdd8-48a30299e302"), Guid.Parse("459ca251-8b87-4d39-9f10-a7b534e9461a"), }, { Guid.Parse("e6260572-d3a7-4aca-8043-9238ca61953b"), Guid.Parse("7f252428-d1c1-4260-a4ad-9dc9f072bb8a"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1e4a7159-71f7-4ec5-9a99-e297ecb2be38"), Guid.Parse("4371734f-994a-48bd-8853-8d8764f8a512"), }, { Guid.Parse("95d65935-d4b4-456c-9214-bed550f84909"), Guid.Parse("2f7a2efb-68a8-4a7b-a012-505a4bf2abfe"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Guid[,] { { Guid.Parse("50d53356-9488-4a40-99df-c9f326c860c6"), Guid.Parse("a542d45b-0627-4316-9f9d-8296d9bb0756"), }, { Guid.Parse("94824b63-4036-4065-a697-5323d2b350f7"), Guid.Parse("d092e176-04de-4ad5-be3b-17960d5b1a54"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Guid[,] { { Guid.Parse("1f71a11e-dc71-4b7e-b8c6-ad014a7486fe"), Guid.Parse("bfeae575-ccfb-48d3-a660-ba57004e81de"), }, { Guid.Parse("499fdc3d-9d96-45ea-a90a-9c5195b5baa8"), Guid.Parse("d9a95b3d-782d-4310-a47e-929a0890d96d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("eb7e5b84-460d-4dd4-818d-56f6795f2a6a"), Guid.Parse("0bab5c5b-3c5e-49ca-b47b-d716aacbdead"), }, { Guid.Parse("17fcd6e9-3fbc-42a0-9878-b214b6872d3f"), Guid.Parse("f0483ea3-5bf6-447f-854b-764533e0ffd4"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Guid[,] { { Guid.Parse("c18f3fa9-1a85-49c3-a97b-2593f6337e94"), Guid.Parse("b13b5302-bfe6-44c3-b4da-3940fd72bbe2"), }, { Guid.Parse("30e946f6-070c-4e95-ac02-ed1254d3d727"), Guid.Parse("00c04b8e-acf4-4576-bc8f-a1ed328567e5"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("eec32162-d308-45df-abf3-d0e7b334ca79"), Guid.Parse("3528e6ee-04ad-43ce-a44c-f516d8ab79d8"), }, { Guid.Parse("709ece01-a7fc-4226-b2cd-99eb568e16f5"), Guid.Parse("0897c1d8-19de-40c4-85d4-bcaa24715b61"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("543d6746-0103-4d2e-8e69-1df5a3c6b075"), Guid.Parse("89e76ca6-f6be-4943-a877-f9dc74655dd3"), }, { Guid.Parse("92fa2373-5fb7-43f0-baa5-c59c546ec25a"), Guid.Parse("7d19558b-e659-463a-9825-5a85189f6e7c"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Guid[,] { { Guid.Parse("d9ecfdac-3424-489d-b11d-6370c9170385"), Guid.Parse("7da491e7-850f-4fb6-b859-815ca1b22587"), }, { Guid.Parse("a6dd10ec-9683-43d1-94cb-221dbd06e21e"), Guid.Parse("fc662eac-7111-4107-86b5-0c4814051e83"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Guid[,] { { Guid.Parse("856a5cd8-ff4a-45c9-825d-e6abfd3a03fc"), Guid.Parse("f419c0bd-1180-4a43-9e1c-22787a2a42b3"), }, { Guid.Parse("b9cd4494-976b-41ff-934d-024087dd6850"), Guid.Parse("5354e7d0-00f6-4117-856b-da27f9da386e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e3b30478-74ef-419c-8160-b48d568844c0"), Guid.Parse("eabc3194-5630-4953-82f9-93decd89b367"), }, { Guid.Parse("261936d7-3602-4412-a497-896568d01a7d"), Guid.Parse("364861d8-482e-4e79-9891-8899392398f4"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Guid[,] { { Guid.Parse("6c55779a-bc8e-4985-ae13-34ea45141458"), Guid.Parse("a2b0742d-9c74-44d6-b8a4-4f50229e9b94"), }, { Guid.Parse("490507d9-7172-403f-8da2-f25819883ebc"), Guid.Parse("ebfe8587-7da0-47b9-9131-9fa2c12735a4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Guid[,] { { Guid.Parse("c35804ba-7790-4522-a72b-080fb3748abd"), Guid.Parse("57fa3b52-0913-4d2e-802c-94a55736a83d"), }, { Guid.Parse("807f4bca-5cb5-47b9-a44f-e7e1a9422682"), Guid.Parse("a83d84d8-84b4-4128-a853-6f826e386406"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("522b2623-4be7-4779-bfed-4d4a1a8cd476"), Guid.Parse("47423b69-7a54-4a00-999e-65d44ad2a4f2"), }, { Guid.Parse("e60aa281-9211-45e4-a6b6-a5b883c99b29"), Guid.Parse("b74aa780-6634-4ff7-921f-4e0ad224ba17"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 178,
    Value = 
new System.Guid[,] { { Guid.Parse("c599dbb6-f931-43ce-84df-75d3c07056df"), Guid.Parse("be825d16-8619-4fc5-ab54-d904c69c29ee"), }, { Guid.Parse("ffcae5be-d7a6-4283-94e0-be568fd3e7fb"), Guid.Parse("933bfd75-ec0a-44fb-b8be-0007b90be22d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 176,
    Value = 
new System.Guid[,] { { Guid.Parse("b500da15-030e-44e4-b562-b64a56a3851e"), Guid.Parse("3279fb84-656d-404b-841d-a898fdfe9a4a"), }, { Guid.Parse("7c31c897-ed64-4a55-9ec3-d20c7f47dcc6"), Guid.Parse("e041c9f2-5a11-42ba-b736-b9075fe98891"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2702b9be-94aa-4312-87c5-e98f1264241f"), Guid.Parse("ef2c2990-28af-45dd-92e4-5cfd90fee207"), }, { Guid.Parse("d17b66ae-79c9-419a-bfc6-6713f2aee276"), Guid.Parse("34bbadfc-ac3c-453f-82ac-a4d736c7b946"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e638ffcf-421a-48c5-a09f-e745fbd18ead"), Guid.Parse("6ac9909f-ac8d-4076-b583-cc8851ff33ef"), }, { Guid.Parse("df7c14b5-334a-4c9d-af90-ad4c07351648"), Guid.Parse("f4604279-0054-4fc5-97e6-c01a345f92ab"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 186,
    Value = 
new System.Guid[,] { { Guid.Parse("de25b04e-66c0-4c4e-8027-9edd0f074fe1"), Guid.Parse("1303bc5a-8c73-45bd-b6e6-e6f3a042b433"), }, { Guid.Parse("153d9585-8082-404c-8a39-7711e89c9540"), Guid.Parse("079c4ecc-f43b-4487-bbeb-3ab83fcd5089"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 179,
    Value = 
new System.Guid[,] { { Guid.Parse("81de20df-fb6b-4bb5-b22a-37d0dae69260"), Guid.Parse("f61d9ec6-a5ee-44a1-9bcd-f931c32b8626"), }, { Guid.Parse("4508cbb2-a956-4d54-959a-3320f38c9cd1"), Guid.Parse("49b1da93-1dc9-4c6e-acea-04206be012be"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c3c82391-847f-436f-806a-ffa1368eec6b"), Guid.Parse("10eaf22e-b945-4fde-9544-dd3ee989032d"), }, { Guid.Parse("43d452e3-9dfb-4160-aa43-b2455a24ca3e"), Guid.Parse("5f5fe3d5-e601-48d0-8c80-6929b9a5bba0"), }, },
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

