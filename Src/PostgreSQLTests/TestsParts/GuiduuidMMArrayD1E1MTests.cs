

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
    internal partial interface IGuidMArrayuuidMMArrayD1
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD1 : IGuidMArrayuuidMMArrayD1
    {


#region TestData

        private readonly GuiduuidMMArrayD1E1M[] _testData = new GuiduuidMMArrayD1E1M[]
        {
            new GuiduuidMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("7dfa6fc7-bf8d-4f82-8b71-931e3a8d81c8"),
Guid.Parse("bfe812e3-f21a-4fad-a143-fc872cfcfe48"),
Guid.Parse("411ca62c-785b-4288-9af8-a0db09bedaf8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7c53923b-abd8-4cc6-8a54-75e271337901"),
Guid.Parse("3bd5ec8a-2f0e-4fc1-997e-a095c314433a"),
Guid.Parse("81357777-2942-4d5f-95cb-c1270586811a"),
Guid.Parse("c09924a9-b952-4fa1-9122-8e1e668725ac"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("5bc292aa-884a-461c-b1b3-5e134fe47963"),
Guid.Parse("376e03cc-6f33-4a1a-b7cc-7e4bcccdd7b6"),
Guid.Parse("fa45d3c5-931f-4014-9657-9b26de1c2d5d"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("1e04e13f-de01-4bec-be3e-61ca31142103"),
Guid.Parse("94bb0ed7-150a-445a-af19-70619c1ff02e"),
Guid.Parse("b78bc9a3-2d38-4070-9049-c973618e9e1f"),
Guid.Parse("6b0318c5-10bf-41cb-b26c-5edbc7e23f22"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3172d1b1-76b8-4727-9e6c-9d7747394b3c"),
Guid.Parse("c72bc62a-9fe6-4ecf-8b64-bdbaedfacdd5"),
Guid.Parse("7624d2a1-be47-47fc-9fd4-b3cc8532006c"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("e9fd2209-d16b-42df-8f0c-d4a3a4459083"),
Guid.Parse("1041a815-e1c5-4f50-9a19-48d5e73394d5"),
Guid.Parse("3a1592c4-3839-4545-928f-c6000eecfc2e"),
Guid.Parse("0effd199-7423-426d-afc8-38113de5efcb"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("a645609d-b2cf-4b24-95b9-306168a2258a"),
Guid.Parse("22c0d3ce-8cd2-4d34-b645-022dad1ec9f6"),
Guid.Parse("025d2185-30d7-4889-a8ba-bdb7bc933031"),
Guid.Parse("102f4512-9b87-4558-b373-836a3d5a9742"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("360a457f-0b82-4d98-8111-29ff67739615"),
Guid.Parse("c0a33a21-2ed3-4a86-bc80-37f86165ddad"),
Guid.Parse("8b831aab-ec9b-481b-a6cc-26723badee80"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5f169707-4f8c-4c59-913d-fa858f7bfb56"),
Guid.Parse("07fc181a-d79e-4026-aa1b-eb14b3e85189"),
Guid.Parse("57becdfc-ade0-4f3a-ba16-505459a32620"),
Guid.Parse("623595a2-7205-4079-b7cc-31a499086eb7"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1aea0d7a-7761-49ad-a88f-02ba238daf6b"),
Guid.Parse("f1aa1c20-41c7-4032-8ba0-99d1e2132fdc"),
Guid.Parse("cc04295f-e327-407c-a00d-f2b24e0acf0d"),
Guid.Parse("25fc0990-2dfb-4f8e-b21e-f3d5d2f41c49"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("f9fbd54a-d038-4644-a83e-e13ce74b8c2e"),
Guid.Parse("89ccbc0a-4898-42a3-8f1e-e65c3854f336"),
Guid.Parse("32afba8b-750b-48a6-a18d-51f9db5b5bc7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("60f9d2ae-2fba-4e1f-9fde-ac134d8c741f"),
Guid.Parse("47c7f8e9-3f5b-4e5b-9fd8-078d7495dcae"),
Guid.Parse("9c6facdc-f91a-4939-8849-2c55cf0587e3"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("0978167e-73c7-4a1e-a0bb-c545e2d9f532"),
Guid.Parse("feca5a0b-ceef-4273-a84c-8acb75c829b4"),
Guid.Parse("3e2d9c6a-bafd-4d2b-9260-c2267652db64"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("624328d9-bfa1-4fb4-b4fb-198d7aba50dc"),
Guid.Parse("dfa70ee0-d1e3-486b-a177-77c2bd8445e7"),
Guid.Parse("c4606da4-22e0-4df6-8d17-68d77b131def"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2c8f1c98-2299-497b-8a91-6e9c70258136"),
Guid.Parse("80619b0a-8a04-4c02-96ee-b6e4b79b9876"),
Guid.Parse("09d9dbc8-3697-4438-815a-308d9f51e932"),
Guid.Parse("ad76d346-a4c6-4645-9d4b-732494e65c4f"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("80f47f14-8e4e-4390-866f-d1ad1847090e"),
Guid.Parse("a42fc547-42db-4f75-8e5e-236a736e769e"),
Guid.Parse("4da23392-7600-42f2-a3bf-5710c4dd1407"),
Guid.Parse("b1d56025-ce6b-44ee-91e4-c9ae6b661e41"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("55cbcad9-7c34-4253-9a29-956570cc08d3"),
Guid.Parse("82c33d77-426b-46dc-a0c4-964c3ccce235"),
Guid.Parse("3ca5451f-7c3a-4fa5-8c22-2e5d03c35e7b"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Guid[4]
{
Guid.Parse("163d441e-72ae-4e84-afc6-431ed666acab"),
Guid.Parse("489014ae-c330-4b2b-ab2d-50a683549d46"),
Guid.Parse("4db08245-092b-4c41-9c7e-d30e54efadc5"),
Guid.Parse("9cb026b1-ffbb-43ef-8a59-d1ae4961882a"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("824a7435-19b1-465f-8151-604db49303c2"),
Guid.Parse("beb3c710-3384-4ea2-b1ba-27c8a8d09001"),
Guid.Parse("49f11a4b-8cc0-4929-80ce-4313991189d8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dff74d88-6fd8-417c-90c7-342685a2f4ed"),
Guid.Parse("f70e39ea-70a2-4295-b821-f98a2917c1c8"),
Guid.Parse("53277c2c-2c28-4b24-a181-20e84b62e324"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("8e835efc-ddbc-4a3e-9cb6-69a35fb1c7cb"),
Guid.Parse("c9e61e49-0e54-487a-a02a-119659343cc4"),
Guid.Parse("3d2a028a-d603-4bbf-b9ef-5fbe1d84a473"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("5e64774f-144a-4f54-8c67-3bd73b4e5c65"),
Guid.Parse("e600e300-596a-4cd9-bc7d-14b204530677"),
Guid.Parse("1470f6bd-9f2b-4a04-9495-d18155252164"),
Guid.Parse("cb0bd360-93a6-48d6-9666-b5905158ea45"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("6d32cc9d-5054-4c95-a510-c6018f83e324"),
Guid.Parse("0aac34b4-1f55-4b33-9b48-894d19685165"),
Guid.Parse("c9476d10-c41b-48fd-b4ac-6bd11d868316"),
Guid.Parse("13f882ad-ed6e-4ec7-b4a2-e031f1b458de"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("46a7dd1d-1329-4dff-88fd-22d2739dd59f"),
Guid.Parse("308fb5e3-bf51-4ab3-967e-f12ed1a8add0"),
Guid.Parse("e00af804-2e79-42dc-ad3f-1c1cf832444e"),
Guid.Parse("8e2e0aac-2e3b-44e3-813e-4745e2361c35"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Guid[3]
{
Guid.Parse("ff585e72-9e20-4911-bac4-564d270a40ab"),
Guid.Parse("9fbd445f-2ef5-4a1e-b326-242685d3eeac"),
Guid.Parse("f79f8261-61af-4746-a710-cf4fe9026929"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("edb4ab68-25bd-4313-9c83-def0fc83dece"),
Guid.Parse("d4027d0c-f454-4739-a6ec-bff16c227977"),
Guid.Parse("564fa712-9d74-4ad5-a16a-b98e58e8bb67"),
Guid.Parse("be24fdad-3112-4512-88b8-a55cbbe2d982"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("6438d423-4dc0-41dd-b448-6df29eb73faf"),
Guid.Parse("db776309-293a-44eb-947e-2a15715f8fee"),
Guid.Parse("7a1fd3b1-546e-4ced-aa9b-9cbf20fa13a6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d8621698-fc33-4de8-a03a-73c6d68a2251"),
Guid.Parse("dab51688-85cc-4518-94c9-085ff9c51cee"),
Guid.Parse("c13a821e-b82b-49e4-ba41-6ddda8ff04c5"),
Guid.Parse("47c01d24-427c-4ec0-953a-8fbe12df40e1"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2f579100-8a48-47cb-be73-20846bfff0ed"),
Guid.Parse("5bb9a8fb-cbc8-49e9-bf03-d4cdb9b2b576"),
Guid.Parse("c39332e4-4a14-49cf-bfe2-b5fcdbb5dda4"),
Guid.Parse("eba7896d-ce2b-4165-8d89-705540eb9746"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Guid[4]
{
Guid.Parse("f6f50df4-b0f5-46f5-9557-d64a2dd8d4a2"),
Guid.Parse("69db8a42-8fc1-4c58-8fad-d1913e8d6d74"),
Guid.Parse("d7d19354-284b-42c0-9879-9899784e4d81"),
Guid.Parse("a13a0315-0d6b-4e6f-8f40-e66f9aeaa2b6"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f34e1d44-8132-4b27-86e1-dbcf829beca3"),
Guid.Parse("c56af7f4-4006-44d1-9f2f-38df34fe068b"),
Guid.Parse("8d26a993-ab74-40d3-9234-acc61a1fb2df"),
Guid.Parse("6dd18fce-348a-44eb-9fab-1abb1702b71e"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("7d9ad813-d842-4286-8184-6a0a8c5ef0f0"),
Guid.Parse("77ca2df0-7ecc-40a2-b051-e13dda27af45"),
Guid.Parse("71307437-a958-44a9-8391-dafd914ae0c0"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("583486fb-8b20-4c22-8b31-d4e1042d2a41"),
Guid.Parse("d3e41d44-dbf9-47a2-b7cb-0d19bfde7c15"),
Guid.Parse("76dfe0a9-3b52-496c-a94d-af47c63c263e"),
Guid.Parse("a3d56b02-651c-4a12-a69a-4c050b257ab6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8e9937c9-0b16-40bf-bca3-70fe7283015b"),
Guid.Parse("7f33670a-8e76-45b2-a564-3d07db06f885"),
Guid.Parse("09a70929-f5e0-444a-8323-c149fee6007c"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("06313f80-ba0a-4792-a854-22b4128f13c5"),
Guid.Parse("ea7d527a-3835-41ff-889e-d2081e92eaca"),
Guid.Parse("0b4d0337-da20-4c64-a8bb-afa108f79726"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0087c9cf-f1ab-46b6-a10c-0a16b5fda91b"),
Guid.Parse("acf515dc-9eab-44d7-a61f-137d745d865f"),
Guid.Parse("f0cb1471-3cc2-4834-a01c-48e6041d2f66"),
Guid.Parse("f2953c62-aba4-4ce3-9a36-b3f7d7ea9db4"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("f1a7ccd8-fb22-4298-b2ce-750a027d8137"),
Guid.Parse("979a4ea4-c1d3-404b-b9ce-140218bab7d5"),
Guid.Parse("89ae4f69-99f2-433b-a664-b78384c17abb"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("0d837ae2-6676-4b62-85f2-c647d8fbd79a"),
Guid.Parse("69d1db47-3b73-496a-bf38-185d809014af"),
Guid.Parse("b2151493-456d-4ee0-b0f4-61255e577734"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e5d0fa81-0282-40d7-9aed-22b721973bf8"),
Guid.Parse("af05923d-fe8d-4c54-880e-472e069e81a3"),
Guid.Parse("40da4e8e-1bef-47dd-81e0-af4283c9c4a4"),
Guid.Parse("e081ac58-c482-4f4a-8c6c-ced07c2c674d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ecf3824c-6b06-4e83-8c65-8e5c149e49e0"),
Guid.Parse("4d6559e0-a9eb-4475-854c-a3c27d2dcc3a"),
Guid.Parse("7b64d183-81e7-4c22-80e4-b69b12880d7b"),
Guid.Parse("137f1758-611c-4b5c-a851-0cb8f33166b5"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("73fccbff-759d-4b6c-bda6-3395a1b221a2"),
Guid.Parse("72089b24-4b53-4c06-b8a0-30d27d3bc9e0"),
Guid.Parse("814172ce-8240-44a2-898b-999e7f0a76e7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("89056bb9-e4f0-4e46-8a60-d6d9469d5da8"),
Guid.Parse("7aee66b8-d166-4bd7-b81a-f243ea27d71e"),
Guid.Parse("b39afdc3-fca1-485e-b7f1-07ff66bccadf"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("1c8393ec-511f-48d1-9289-181933cc752b"),
Guid.Parse("c6b04b6f-bf3d-463e-b77b-21500077149f"),
Guid.Parse("7f98a0fc-506a-4de2-8ba0-05b0a3d95622"),
Guid.Parse("bfd5fada-f4a8-48b3-8e1a-f7d92e1f496a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1c33293d-8171-41d9-be55-443172620e82"),
Guid.Parse("580b2342-2a25-425e-90df-9329b143082a"),
Guid.Parse("fe8f1007-de42-47a4-bd31-aab0bbd604ff"),
Guid.Parse("f7d2c33a-9e75-43ce-8418-b302dbae2a22"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("9c3b2568-83d9-4058-8ba0-ea307805486f"),
Guid.Parse("db7f36a9-d0d8-47ff-86bf-69e3091a46d8"),
Guid.Parse("c695319a-9b69-4d44-bd69-c72a2be8e8f4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("c5adff38-08d9-4f69-98c0-1008553b9fe5"),
Guid.Parse("4885eb5e-71e7-478b-8e65-379667348388"),
Guid.Parse("f9107dbb-de44-43fc-9045-d8efdae2f429"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("06ea8161-0f5a-46bd-ac7d-c3dce5f1b68e"),
Guid.Parse("151ce57a-9593-4dfd-a663-6337acbc43cd"),
Guid.Parse("0b838dca-3874-4377-a9be-d9f4371bfc68"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4a91e32b-b3f6-4bfa-a7a0-d370ec0eec30"),
Guid.Parse("908aa074-fa22-4027-9c6e-c7ebb041efec"),
Guid.Parse("1b4a3c9e-755f-4a87-be0d-57e6cc44ede8"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fc072688-28c2-48ac-b75b-890443ca5540"),
Guid.Parse("0fb776e3-9e7e-46f8-926c-e29024e71b41"),
Guid.Parse("98b9436f-c4a3-4f0c-88f4-9f634ca5629b"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("549c7283-d1e2-4321-a02a-31ccff082ef0"),
Guid.Parse("212ab54e-2ad6-44ad-9b90-015940dcef35"),
Guid.Parse("5807f334-cfa4-435d-88ad-74dbf750b54c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5dd7dc29-31b6-480c-b564-860f7d48d507"),
Guid.Parse("f2025dcb-3716-4a01-924f-bbde833e1c94"),
Guid.Parse("3e6f4d1e-2d21-47be-8770-af8e9f65c162"),
Guid.Parse("c5dbdee7-3140-4fdb-8e11-067ffb646500"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Guid[4]
{
Guid.Parse("e8610d4c-3926-4a8a-a32b-285673d45db9"),
Guid.Parse("74e408e5-7787-4930-9009-82f8b984e0a3"),
Guid.Parse("b5b615d5-9746-4d33-b6ef-47ab6113f798"),
Guid.Parse("2ba3b5fe-7df5-42b2-9b8c-47b8af35e454"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("b3b3e72d-98bb-42ce-bbe1-f871f7e1e821"),
Guid.Parse("46ff8826-f182-4960-a6e4-5fb530b3f206"),
Guid.Parse("b3cba9de-db02-4bcf-a1e6-3993c995c37e"),
Guid.Parse("e51ab37c-9ee0-47ad-9e2e-c8bb9c0f11d1"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a4476533-b5f6-44d5-9834-7056a9b3c809"),
Guid.Parse("bd75260f-05a2-45c7-be10-b82a84ece125"),
Guid.Parse("2525314a-6c52-45b3-9f36-6bd06804c1d2"),
Guid.Parse("6ec94ca9-5dbe-485d-9771-13f6548a5e02"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("2413a16c-c8da-4398-a1ac-65cba968c22a"),
Guid.Parse("938de4cc-1dcb-49c8-9d55-dfffdaf175c7"),
Guid.Parse("21e3a942-63d4-4baf-8a2a-29a68813e36d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3af8881a-eca0-412c-9b40-aa2b678cd65b"),
Guid.Parse("387519a2-8acb-469e-90da-f2d2ac10d926"),
Guid.Parse("120aea16-21c7-49bf-941b-1920ca477d12"),
Guid.Parse("520d02a9-5530-4fd8-8f5d-3423bc655556"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("c866146c-8b38-4c54-a67d-9d9f953530c1"),
Guid.Parse("231e0352-60b5-4994-8a49-ce244fb52777"),
Guid.Parse("05f346d5-808b-4a13-84a2-493b93760677"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("8b34416e-9d8a-4f09-b166-04f830115895"),
Guid.Parse("855fa9dd-f413-4e25-887b-2f4eff5417a4"),
Guid.Parse("64e5646f-02f0-4ffa-94c8-f31673a5f333"),
Guid.Parse("df2c1c3a-199d-45f2-a9cf-ecfee67c8352"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b7393e9f-e9e3-45cc-983d-906b18e0c0ae"),
Guid.Parse("bba19afe-ade6-4c79-a7fb-80ce1411877f"),
Guid.Parse("b5e8840a-7996-477b-a54f-cd1ddd4dbddd"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Guid[4]
{
Guid.Parse("c487af3f-d6df-4d75-a891-029516efa5cb"),
Guid.Parse("38f6ab3d-e0f5-423a-bb6a-78e9ebdb91e0"),
Guid.Parse("2de6e746-b40f-4c3c-a98b-760c391cf0be"),
Guid.Parse("6487b530-1b9e-4359-9795-37dff1eb9efc"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b6985519-e80f-4a25-a073-518a127c4469"),
Guid.Parse("52433584-45ae-42e4-9d37-b7824d63603a"),
Guid.Parse("174acd2e-b160-4522-84a9-7cad865c9aec"),
Guid.Parse("732001ba-4385-4743-bac3-444ed9b8b575"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("b043202e-89ed-48f6-ac21-36a4758a90ed"),
Guid.Parse("c47240d8-0f6a-46c2-8973-71b28e640431"),
Guid.Parse("bbb88baf-5359-483e-8295-72aa4af63f84"),
Guid.Parse("db6d9efd-1799-4de6-b27e-5203717bc892"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("f4d3954c-365e-402e-9dd5-0066f055b83a"),
Guid.Parse("23a52cfb-42a7-401d-b570-f263f53a32b8"),
Guid.Parse("3083bcb6-2977-4dae-97d0-f4cacd96db55"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4d9c36df-865d-47fe-ac63-5d7216ad233b"),
Guid.Parse("363b7173-9e1b-4d0f-a920-7c09500ebc36"),
Guid.Parse("7e2121fc-c2e1-4f28-9599-9f807c1ba301"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("70277c0f-61c3-4c6c-8284-ec55a44cf29a"),
Guid.Parse("3c8c1ae7-02ec-4ca3-9637-62cf0c39ca49"),
Guid.Parse("8cbd8afa-a0bf-4b6c-9a6c-63dca3afc44c"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("de116f79-7072-4252-9c65-8fa4b8a7f9b9"),
Guid.Parse("9774a007-b536-44c7-878c-c76725150c49"),
Guid.Parse("063cf814-fd29-4882-83be-519068a2254a"),
Guid.Parse("45c74726-19c7-4ce5-b77b-88378166c023"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Guid[3]
{
Guid.Parse("8ccfec0b-f441-4437-8707-f451d9ec5c30"),
Guid.Parse("25743c89-db9d-4df4-a98d-faff51a0b380"),
Guid.Parse("2da381d7-0bd8-4a41-8e2f-46d4b7167fd8"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("38b28f09-4428-4ae5-b7e0-c46f296107f0"),
Guid.Parse("a1771d68-642b-403e-b9da-233aeffa4b81"),
Guid.Parse("40cf9403-3d90-44e3-94f4-7f876f9ed2fe"),
Guid.Parse("17cf4c6f-e1a6-46a2-aedf-723de916819c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Guid[3]
{
Guid.Parse("8c9c8edb-2afe-4180-9b7b-0a6b0d57b84c"),
Guid.Parse("8744db87-268f-47bd-a956-2bca33a0fcee"),
Guid.Parse("f93bbb12-bad6-464c-b604-789fb322da0d"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("c1285aaf-c199-4f05-87f8-2c2ca6397c08"),
Guid.Parse("a356e6b0-0ae1-4948-920a-89addad08bff"),
Guid.Parse("d6fda0c6-779e-4e12-a1a9-9944d7e70770"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("a7c4a88b-e80b-4408-a32d-8be93ed9c760"),
Guid.Parse("97705a17-1833-424b-98cf-9a620aee3963"),
Guid.Parse("f13b0fa8-d137-4fdb-a27e-e78fa59a96fd"),
Guid.Parse("3481f9ef-624f-4ef7-87f8-507747a79943"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Guid[3]
{
Guid.Parse("5df7f267-c8a8-4587-a73a-970bed31dbc9"),
Guid.Parse("514da75e-cc42-42e1-b2ae-0deddcb540ba"),
Guid.Parse("52484997-d78a-4a80-9116-ed142d635b57"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b976b814-07fd-44a8-a424-3e418f9025da"),
Guid.Parse("aa625c14-b739-47c0-9d3f-cfdf09c79ce3"),
Guid.Parse("161d235a-ca71-4fd4-9b65-217e755c83f0"),
Guid.Parse("4062265b-34b3-4c56-8d10-832323fc3417"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Guid[4]
{
Guid.Parse("7a0ddbf1-a89d-4cc0-8c3c-dd5d8fdb2807"),
Guid.Parse("d17c6397-277e-41f6-82d2-a53e58692e97"),
Guid.Parse("09ccd707-ce56-41d6-af9a-8e6dec736d5a"),
Guid.Parse("e17f30ee-3fbf-4e86-9760-347be6c43fda"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("427661c0-db2c-4c32-b82e-3bc33f84fef4"),
Guid.Parse("bb634bb7-f245-4155-a19b-eefd91bf586a"),
Guid.Parse("dc1a5a7a-74c8-4c84-8d0b-03f06c7e8a22"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7723d11b-4970-401c-9e7e-1ca2380fd0eb"),
Guid.Parse("14e7054c-cb3b-4ff2-be46-9532539f81cb"),
Guid.Parse("4441815c-1cce-4a74-9464-4b32a5f8d760"),
Guid.Parse("c222f148-e45e-4796-acad-be9f5648a3b4"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1e49cf99-eddf-4fab-9762-ab6046fa7e24"),
Guid.Parse("8312ac26-37c2-4549-85c6-ddc0c108c316"),
Guid.Parse("dc9452d5-06f5-48d2-9249-0f8397b6f8a0"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Guid[4]
{
Guid.Parse("7c34c1e1-85ee-4154-b56f-60639574efa8"),
Guid.Parse("547ae69a-3cb4-4fcc-8f45-696ad21165a9"),
Guid.Parse("73788f2a-b8a6-4978-8243-11f4c61cfb0c"),
Guid.Parse("db665f87-e7b8-41c3-8783-d6c637ff3e66"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("41d92d92-04ac-4abb-b728-6cdb61e20cc2"),
Guid.Parse("d63a48ea-8cb0-44f1-ac5a-76ea86abdd40"),
Guid.Parse("3c310eb6-a384-4490-b9d9-1934096a34c7"),
Guid.Parse("1e3491cd-00a1-4e9a-957c-aff002333414"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("6e04d318-0d8c-4d66-811e-bed2ab3f7cb9"),
Guid.Parse("ae18ea64-9d8a-49b4-bedf-09fed30d5097"),
Guid.Parse("cf65f935-e00c-46ee-af22-e3e5cecece51"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("2cbcaa4b-e59d-4dfd-bed2-6d6bf5cebde9"),
Guid.Parse("6e091432-b79c-45fc-93db-67b386573d3c"),
Guid.Parse("d7013065-5121-4589-a0dc-c362e6ec7a06"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("983b934f-eaa9-4351-ab00-240b4dbb1a19"),
Guid.Parse("a353e5de-7db5-49a8-9d0a-796dd9c585b6"),
Guid.Parse("d49b649c-66fb-4d76-aa5d-f66a05d39572"),
Guid.Parse("4d8b23a0-bcd2-4fa9-9a58-b65af22b1eb0"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d4c20c96-cc51-4730-88c2-3301dac6c5e9"),
Guid.Parse("85154f9a-0e35-44c5-bd43-9b737caaf4a6"),
Guid.Parse("66c5eb84-b2b6-4ad0-a8ac-b40fd78abd66"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("f7d440ef-8a75-4d18-8600-4b96c57d432a"),
Guid.Parse("4a7be3ab-01e4-4c55-82d8-e440af188f17"),
Guid.Parse("8581a6d5-2a62-46b6-b42b-209b7cf0e9db"),
Guid.Parse("fdf1a1ac-27ca-4d78-ba3b-8ea70fad69c3"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("60f9d2ae-2fba-4e1f-9fde-ac134d8c741f"),
Guid.Parse("47c7f8e9-3f5b-4e5b-9fd8-078d7495dcae"),
Guid.Parse("9c6facdc-f91a-4939-8849-2c55cf0587e3"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("55cbcad9-7c34-4253-9a29-956570cc08d3"),
Guid.Parse("82c33d77-426b-46dc-a0c4-964c3ccce235"),
Guid.Parse("3ca5451f-7c3a-4fa5-8c22-2e5d03c35e7b"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                System.Guid[] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("2f579100-8a48-47cb-be73-20846bfff0ed"),
Guid.Parse("5bb9a8fb-cbc8-49e9-bf03-d4cdb9b2b576"),
Guid.Parse("c39332e4-4a14-49cf-bfe2-b5fcdbb5dda4"),
Guid.Parse("eba7896d-ce2b-4165-8d89-705540eb9746"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 120, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 112, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 70, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 124, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD1E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
FROM public.binary_guiduuidmmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI), typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

