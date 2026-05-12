

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

        private readonly Guidv7MArrayD2E1M[] _testData = new Guidv7MArrayD2E1M[]
        {
            new Guidv7MArrayD2E1M
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-715c-ab8d-c0b490d7457c"), Guid.Parse("019e1b45-9086-7307-bb5b-472300f92e0c"), }, { Guid.Parse("019e1b45-9086-7aa1-9801-5ce4cf502537"), Guid.Parse("019e1b45-9086-7dfa-97e8-2ecdf4f2498e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7e28-aaf0-699fa5c2d563"), Guid.Parse("019e1b45-9086-7a5c-b336-e8eb46c79b93"), }, { Guid.Parse("019e1b45-9086-700e-b82f-5070ddb2d87d"), Guid.Parse("019e1b45-9086-72e1-9f5c-4e84fb1da5a0"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-78ab-b053-fd9832d5b812"), Guid.Parse("019e1b45-9086-79ee-a364-da57bc66d5ae"), }, { Guid.Parse("019e1b45-9086-7f7c-8e5d-e590692e646c"), Guid.Parse("019e1b45-9086-7648-9ee6-c38207cd14d0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-788b-bf3a-a0ba42f7a9ef"), Guid.Parse("019e1b45-9086-7097-b7bd-5b5bcea681c8"), }, { Guid.Parse("019e1b45-9086-706d-9d56-a33bad7f9dae"), Guid.Parse("019e1b45-9086-7ece-97e9-b11972e111cd"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 9,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7a2c-84fc-c3090d871d78"), Guid.Parse("019e1b45-9086-7f0a-bfcf-e299c042f6a3"), }, { Guid.Parse("019e1b45-9086-79e5-9326-9562d8acdbfd"), Guid.Parse("019e1b45-9086-7bd7-9611-f5fe1ea6d9c2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7606-b95f-9d4a6be787b1"), Guid.Parse("019e1b45-9086-7ae9-8e31-da832950e20f"), }, { Guid.Parse("019e1b45-9086-7b6a-bf36-917383107e5f"), Guid.Parse("019e1b45-9086-721c-9c87-901d5954b103"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 12,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7f7f-8b6a-16fec63a842f"), Guid.Parse("019e1b45-9086-76a6-bbac-0fc727e723c4"), }, { Guid.Parse("019e1b45-9086-7024-990f-159cc23a99a8"), Guid.Parse("019e1b45-9086-7b24-b4b1-b94e75d28e24"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-70e7-8df8-98769211fab6"), Guid.Parse("019e1b45-9086-7526-a07c-dfdb00bef833"), }, { Guid.Parse("019e1b45-9086-7fae-a60d-d663bfc0f284"), Guid.Parse("019e1b45-9086-7e7a-a40e-dab81415edc9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-766f-90a5-3dfa65967eb5"), Guid.Parse("019e1b45-9086-7c8f-8edc-816c1c47349e"), }, { Guid.Parse("019e1b45-9086-7c25-b784-662b17f5d8ee"), Guid.Parse("019e1b45-9086-71c2-a115-3da709b47545"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-704e-b525-3671a2d42dab"), Guid.Parse("019e1b45-9086-75e3-86a0-f9236ed1c664"), }, { Guid.Parse("019e1b45-9086-7052-b38a-31f1db903a6d"), Guid.Parse("019e1b45-9086-7660-ace1-73aa9a699700"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7d54-a4c9-b115c61902a5"), Guid.Parse("019e1b45-9086-7386-90a7-26a87708ef3e"), }, { Guid.Parse("019e1b45-9086-7f0a-a7f8-8dd47f8d0687"), Guid.Parse("019e1b45-9086-7163-bb9f-9f6c9c14a985"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-785d-a7d6-acb1e8f18a9c"), Guid.Parse("019e1b45-9086-70f7-9aef-483e76158778"), }, { Guid.Parse("019e1b45-9086-71c7-a25d-de26411724de"), Guid.Parse("019e1b45-9086-78de-b569-326e81658d1f"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7554-9f74-92544bf91036"), Guid.Parse("019e1b45-9086-7106-ad15-f89201fbe3b2"), }, { Guid.Parse("019e1b45-9086-7684-8267-673bc94ef53c"), Guid.Parse("019e1b45-9086-7612-9e8c-b45996c675ec"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7200-9af8-94c9ec44fad2"), Guid.Parse("019e1b45-9086-785c-a25a-d5b80e434476"), }, { Guid.Parse("019e1b45-9086-7b71-8ea7-1747735241ab"), Guid.Parse("019e1b45-9086-79e3-bde5-fd36319c429a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-750c-baf0-ed4f6ad0b924"), Guid.Parse("019e1b45-9086-7a48-9041-02b3fbb75d06"), }, { Guid.Parse("019e1b45-9086-7dc1-819d-bf06fbac5980"), Guid.Parse("019e1b45-9086-76e2-8ab3-12cac69c6784"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-70e7-be5f-a09fd03a4a4f"), Guid.Parse("019e1b45-9086-7f0e-8976-7e23b044dbfb"), }, { Guid.Parse("019e1b45-9086-7f5e-9c9f-edba27d8057b"), Guid.Parse("019e1b45-9086-7d72-8524-208e975b645a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-748c-aa67-f1a328c32d4b"), Guid.Parse("019e1b45-9086-7c27-b675-292713fdced0"), }, { Guid.Parse("019e1b45-9086-7f8e-a47a-5d89b8f197d5"), Guid.Parse("019e1b45-9086-7a2c-aedc-1acbdf55c8e5"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7538-8dc0-3f7b9729f773"), Guid.Parse("019e1b45-9086-7554-bf3b-bca956af2ebb"), }, { Guid.Parse("019e1b45-9086-723d-82b3-42efa96214d7"), Guid.Parse("019e1b45-9086-7a7b-a999-cfcc6d17a1d3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-78eb-a77e-49400f07d0b9"), Guid.Parse("019e1b45-9086-7569-bd44-4d6c5765c8b8"), }, { Guid.Parse("019e1b45-9086-7897-9429-af14192307a7"), Guid.Parse("019e1b45-9086-766b-a91d-fc1baee35c07"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7c07-9e6a-efd61239d610"), Guid.Parse("019e1b45-9086-7675-b2f5-cb98d563f5fa"), }, { Guid.Parse("019e1b45-9086-7901-8fa7-01d408d224ce"), Guid.Parse("019e1b45-9086-7aad-8eee-b49eebf59c2a"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 36,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-709d-ac35-9733f038fe2c"), Guid.Parse("019e1b45-9086-7a5d-b1c8-4b6f0ee9eddc"), }, { Guid.Parse("019e1b45-9086-7d5a-b584-5db4243ce6d5"), Guid.Parse("019e1b45-9086-79f2-b3cc-634952969074"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7798-81b7-f80c8dc4822a"), Guid.Parse("019e1b45-9086-78f8-97a7-6d2f9ec39404"), }, { Guid.Parse("019e1b45-9086-7cd7-9a77-1667da00c9c0"), Guid.Parse("019e1b45-9086-7a3d-aca6-cb5cb42d580e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7a25-8bd7-5542739c5e58"), Guid.Parse("019e1b45-9086-7938-b2c7-94916296d824"), }, { Guid.Parse("019e1b45-9086-79cb-90c4-7e027196d859"), Guid.Parse("019e1b45-9086-73d3-99f7-f9750ec864ec"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7998-8c2a-0f1ae9d53d68"), Guid.Parse("019e1b45-9086-77e7-aee1-710730b12a9f"), }, { Guid.Parse("019e1b45-9086-7c2f-8cb9-2c6db017b386"), Guid.Parse("019e1b45-9086-7972-9f36-339dd0a713d1"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-706d-b251-30ea964c8413"), Guid.Parse("019e1b45-9086-78bb-8f34-c159baa49235"), }, { Guid.Parse("019e1b45-9086-76a0-a6a2-014dc8eef1c3"), Guid.Parse("019e1b45-9086-7643-98dc-9175fbda2903"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-711e-934a-c4e90e707dd7"), Guid.Parse("019e1b45-9086-7052-87e1-412a75d897b5"), }, { Guid.Parse("019e1b45-9086-727d-bc1a-d70224585378"), Guid.Parse("019e1b45-9086-7280-a894-021e757c6171"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7ae1-9b8a-93ceab56bb89"), Guid.Parse("019e1b45-9086-762e-af87-821f215219f0"), }, { Guid.Parse("019e1b45-9086-7197-87dc-dfee2383dca8"), Guid.Parse("019e1b45-9086-736d-b74d-6498e2afe5e0"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7e41-8198-d7e91d8b994c"), Guid.Parse("019e1b45-9086-77a9-9aa6-1c03f1e0d8ca"), }, { Guid.Parse("019e1b45-9086-78c8-baa0-f019aae78595"), Guid.Parse("019e1b45-9086-7222-adfe-116cedd524fb"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7047-bae9-e0c5e37cbb3b"), Guid.Parse("019e1b45-9086-7438-8b4c-0978b8dd950b"), }, { Guid.Parse("019e1b45-9086-7121-86a2-61d3fa73517b"), Guid.Parse("019e1b45-9086-704f-a028-07bb95b29b54"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-766b-b719-1984b9d3d989"), Guid.Parse("019e1b45-9086-7d8a-9c00-b2b81a4d0531"), }, { Guid.Parse("019e1b45-9086-7dc5-8c44-292d7994816f"), Guid.Parse("019e1b45-9086-72d7-b5e6-686b9604c03e"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7fbd-bd01-74ec32ec87a6"), Guid.Parse("019e1b45-9086-7089-aedd-295a330dc9dd"), }, { Guid.Parse("019e1b45-9086-737a-93b1-276fb30dd3e1"), Guid.Parse("019e1b45-9086-7b9e-ad4f-f1f2812cac7c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7fa7-a7da-deebd5d6c3f8"), Guid.Parse("019e1b45-9086-7ff5-96e4-fef9dc5c8c0c"), }, { Guid.Parse("019e1b45-9086-74a7-a520-9aa48b1884f6"), Guid.Parse("019e1b45-9086-748c-b162-eb2d20b1145a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7245-9c1c-6541ff1e064e"), Guid.Parse("019e1b45-9086-7480-a83c-24b34d6c8b78"), }, { Guid.Parse("019e1b45-9086-700b-af04-372c5f7668a4"), Guid.Parse("019e1b45-9086-7492-9b9e-d54b1698fc8e"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 56,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7202-bf50-62be3ab89b9f"), Guid.Parse("019e1b45-9086-7e7f-b0fd-2b376738df22"), }, { Guid.Parse("019e1b45-9086-7fa4-8b03-e954ddd6ccf2"), Guid.Parse("019e1b45-9086-71c3-b426-86b03acba7c3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-77d2-86a7-c8aa46bfbce7"), Guid.Parse("019e1b45-9086-7fc4-a580-019e1deeafa6"), }, { Guid.Parse("019e1b45-9086-79c7-8eea-43148f251f1c"), Guid.Parse("019e1b45-9086-7689-949e-fbd9caa9eb22"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7f24-8ba3-41beb6dc3180"), Guid.Parse("019e1b45-9086-7f72-8638-0637a9c84b21"), }, { Guid.Parse("019e1b45-9086-7d2c-b1e9-525337819415"), Guid.Parse("019e1b45-9086-736d-9ec9-17887d7d1dd8"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 63,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7971-ad06-00939a23c2f1"), Guid.Parse("019e1b45-9087-73c1-99ec-57af3062714e"), }, { Guid.Parse("019e1b45-9087-7b65-9335-7bc20a4bda3c"), Guid.Parse("019e1b45-9087-7809-81ad-25ab61f3714d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9086-7b82-af07-94ce91c8aa07"), Guid.Parse("019e1b45-9086-7554-ba29-1036c11b0e2b"), }, { Guid.Parse("019e1b45-9086-75c8-aa7e-6cb3fb8e09a0"), Guid.Parse("019e1b45-9086-7be6-a7a8-57463a341f08"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-73fa-bde1-6b5284da176f"), Guid.Parse("019e1b45-9087-7736-9e58-a473bc2090ff"), }, { Guid.Parse("019e1b45-9087-7978-b7e0-978b6169face"), Guid.Parse("019e1b45-9087-73f4-8c42-b685fe75da68"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-73c0-991f-e6f84cfce8ab"), Guid.Parse("019e1b45-9087-7240-ad2c-ee68a70ca6bb"), }, { Guid.Parse("019e1b45-9087-7f93-bcd9-a0d1b3bb2188"), Guid.Parse("019e1b45-9087-7a72-9109-835793aeec9d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-761b-8df7-b1d43d5ce42d"), Guid.Parse("019e1b45-9087-745c-bc56-a89c9ab92f7b"), }, { Guid.Parse("019e1b45-9087-7d13-89d5-3ae2c3b6bc6c"), Guid.Parse("019e1b45-9087-7590-a619-279849907997"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7d85-bc97-b1a0d4827d22"), Guid.Parse("019e1b45-9087-7d36-9610-c5184faab283"), }, { Guid.Parse("019e1b45-9087-77a7-8dbd-33836c2fd6f3"), Guid.Parse("019e1b45-9087-71d2-8d4c-5b3010d0b635"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7402-9c72-1381c852bc59"), Guid.Parse("019e1b45-9087-7fa8-9372-ba37b2cfcf29"), }, { Guid.Parse("019e1b45-9087-7747-9022-a3dca3201946"), Guid.Parse("019e1b45-9087-7f5a-852f-6f956ddab988"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-72aa-ae8f-93d38fc9a781"), Guid.Parse("019e1b45-9087-7220-8aaa-3dcaff1996db"), }, { Guid.Parse("019e1b45-9087-7231-8fa5-c5423a4c6803"), Guid.Parse("019e1b45-9087-772a-a3c3-cc051c2375e2"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7ad2-aa2c-95231ac49e24"), Guid.Parse("019e1b45-9087-7bb5-a3ed-3e9b611e6c94"), }, { Guid.Parse("019e1b45-9087-72e5-b182-1e45cf33ec92"), Guid.Parse("019e1b45-9087-7487-8ad7-30558d53a601"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 69,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-70a9-a2a5-bb710fab8fec"), Guid.Parse("019e1b45-9087-778a-9ee1-097ce287f49c"), }, { Guid.Parse("019e1b45-9087-79b4-bb05-fc61bc686315"), Guid.Parse("019e1b45-9087-7895-9edb-34da69ed1675"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7799-8dd2-2367e0062aea"), Guid.Parse("019e1b45-9087-7d46-9d40-f90625e11f6f"), }, { Guid.Parse("019e1b45-9087-781c-9a0f-5779eaee72cb"), Guid.Parse("019e1b45-9087-72eb-bafb-5c8a92ab6db9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-716b-b555-e0b7b72211f3"), Guid.Parse("019e1b45-9087-72d2-9814-4b462dae456a"), }, { Guid.Parse("019e1b45-9087-7643-b22d-2fc55a6c1528"), Guid.Parse("019e1b45-9087-7f05-9b5b-f6c9da282500"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-73db-9e6b-605d2e13e43a"), Guid.Parse("019e1b45-9087-74c6-90d4-206414464677"), }, { Guid.Parse("019e1b45-9087-7d6d-9daf-ef02481cd85e"), Guid.Parse("019e1b45-9087-7400-b05a-e04f888377c7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7921-b6d1-4f2bd4b58f3b"), Guid.Parse("019e1b45-9087-7c90-b87a-730fcb3bbdcb"), }, { Guid.Parse("019e1b45-9087-7dc4-b7ef-7a2b39a4dea5"), Guid.Parse("019e1b45-9087-7859-a310-aec074b1cf74"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7d01-8886-3db1a77440ae"), Guid.Parse("019e1b45-9087-7312-9b95-8b01d7058ee3"), }, { Guid.Parse("019e1b45-9087-758c-ab1c-8a7cb9136376"), Guid.Parse("019e1b45-9087-717a-9af4-417308a77c76"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-76b8-a81c-f4e39b159e3b"), Guid.Parse("019e1b45-9087-78b1-8034-b46ab6b349e5"), }, { Guid.Parse("019e1b45-9087-7769-8cd4-d8457ca059da"), Guid.Parse("019e1b45-9087-7c0d-ba81-03cb4c437fe2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-737e-9715-139f52c60cb3"), Guid.Parse("019e1b45-9087-7538-a850-c36a1bedaa00"), }, { Guid.Parse("019e1b45-9087-7dfb-b2f2-96404cb5e02b"), Guid.Parse("019e1b45-9087-7fc5-8946-cec76529d75f"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 87,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-772c-8127-607974c14987"), Guid.Parse("019e1b45-9087-7ce1-b256-f56bba10bcd5"), }, { Guid.Parse("019e1b45-9087-7ff5-8296-bf889c06935b"), Guid.Parse("019e1b45-9087-7e71-84e1-c2d000eac2d8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-743d-a9b9-4fc300ff5855"), Guid.Parse("019e1b45-9087-7d37-a6f1-ca28699e8243"), }, { Guid.Parse("019e1b45-9087-7543-8d94-b35c765cd2a8"), Guid.Parse("019e1b45-9087-784a-aa27-35209cfee56d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7983-a7f8-8a0fe1b5f318"), Guid.Parse("019e1b45-9087-7d90-bd75-60f8ef4731d0"), }, { Guid.Parse("019e1b45-9087-7fd8-a99e-9d4600295047"), Guid.Parse("019e1b45-9087-7add-b807-97710385d69f"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7fd8-8a52-3672e817452d"), Guid.Parse("019e1b45-9087-77b0-9e31-e47118a1fead"), }, { Guid.Parse("019e1b45-9087-7f54-b343-292bb963a351"), Guid.Parse("019e1b45-9087-74a4-9e02-33354bc337bc"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7be4-8b14-3cdef95e5a68"), Guid.Parse("019e1b45-9087-77e3-9047-b7fbb4750854"), }, { Guid.Parse("019e1b45-9087-7f16-9b89-7b448a2f9a08"), Guid.Parse("019e1b45-9087-7636-a65f-48faeb5ff114"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7be7-af55-772ebeae0cce"), Guid.Parse("019e1b45-9087-7838-84d1-7e9105f65755"), }, { Guid.Parse("019e1b45-9087-778c-a03a-5a5298b9d4b5"), Guid.Parse("019e1b45-9087-7b28-83c2-019aa639ad5f"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7b35-827c-58a766f46aa6"), Guid.Parse("019e1b45-9087-7333-abdc-9536c84e0644"), }, { Guid.Parse("019e1b45-9087-7164-bbf4-d1d334c6d6d7"), Guid.Parse("019e1b45-9087-7bfe-acf9-e10ff93001b2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-700f-bc78-c219e5565ba3"), Guid.Parse("019e1b45-9087-7b33-86f1-591391e0e216"), }, { Guid.Parse("019e1b45-9087-7486-aac8-c06f9d65dc08"), Guid.Parse("019e1b45-9087-7a20-981f-1e706c52601b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-778c-9073-3d17204eff71"), Guid.Parse("019e1b45-9087-7b2c-bf69-c081282ec147"), }, { Guid.Parse("019e1b45-9087-77ee-9649-03ac2693605c"), Guid.Parse("019e1b45-9087-7051-93da-165de23662a1"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-75bc-bd3f-db69e388aaf7"), Guid.Parse("019e1b45-9087-7010-a413-f57fa66fc86d"), }, { Guid.Parse("019e1b45-9087-7ba3-a72f-785f1961946f"), Guid.Parse("019e1b45-9087-7737-81d3-255d1f106868"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7755-9272-6935c9ae991f"), Guid.Parse("019e1b45-9087-763e-9194-d88704abd335"), }, { Guid.Parse("019e1b45-9087-74c6-bcba-4685341f3e6e"), Guid.Parse("019e1b45-9087-75b2-93c6-81d6ac2236f2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7c6b-8d28-804a11699ac5"), Guid.Parse("019e1b45-9087-724a-a5a0-b0fd2a33c0a3"), }, { Guid.Parse("019e1b45-9087-75c9-8014-7e9ec7e086e5"), Guid.Parse("019e1b45-9087-708e-8c5f-9ed622b180d5"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7492-aea1-83ef0470d349"), Guid.Parse("019e1b45-9087-76ea-916a-bb08b2980d06"), }, { Guid.Parse("019e1b45-9087-783b-b786-63aab08835fd"), Guid.Parse("019e1b45-9087-7dd5-821a-e882040ba578"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-79fe-a0eb-336aa67a82d0"), Guid.Parse("019e1b45-9087-793a-9286-b10ca351bb34"), }, { Guid.Parse("019e1b45-9087-7d10-a82f-7557b9387d25"), Guid.Parse("019e1b45-9087-77bf-84d9-d9ff756c2046"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-72f9-83c9-d6d3af506f4b"), Guid.Parse("019e1b45-9087-7bcc-9b76-a0ff709bf664"), }, { Guid.Parse("019e1b45-9087-77f6-be55-0e0b6379101d"), Guid.Parse("019e1b45-9087-71f3-b441-c19309b36d73"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 113,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7fed-a570-1f0d7893bf05"), Guid.Parse("019e1b45-9087-764b-9ee3-8fee4d1b741c"), }, { Guid.Parse("019e1b45-9087-777a-85ac-aad4da35523e"), Guid.Parse("019e1b45-9087-7657-8eef-37e3ab3d241a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-71f3-9abc-d382518050cb"), Guid.Parse("019e1b45-9087-7fc3-82bc-60ad5597ed28"), }, { Guid.Parse("019e1b45-9087-75d0-a977-8b58330ec742"), Guid.Parse("019e1b45-9087-74ec-bf49-181daf203af9"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7121-a64c-8345fccc65d7"), Guid.Parse("019e1b45-9087-7888-bc1b-44c94b6fd9e8"), }, { Guid.Parse("019e1b45-9087-7342-9e0b-6840c7deb3e1"), Guid.Parse("019e1b45-9087-79e4-a019-331bdaaf3948"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 116,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7fa4-8465-e0a88132ed51"), Guid.Parse("019e1b45-9087-7959-819d-c83bf4a15309"), }, { Guid.Parse("019e1b45-9087-76a6-a911-280b1d0430b1"), Guid.Parse("019e1b45-9087-70c1-863b-6c6984b16e15"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7307-a9df-bb6ac26c07e5"), Guid.Parse("019e1b45-9087-7db9-890d-4fed394ad9db"), }, { Guid.Parse("019e1b45-9087-73e2-9016-d6eecc93c8eb"), Guid.Parse("019e1b45-9087-748a-aea5-11021c322f26"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 117,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-79a5-b0e4-caabab14195a"), Guid.Parse("019e1b45-9087-77a2-a303-ed07c4ae6d86"), }, { Guid.Parse("019e1b45-9087-74d1-bac8-638021318d95"), Guid.Parse("019e1b45-9087-71f3-8ac1-ac6af883c2d7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7dd5-b515-f19ef7d53bd0"), Guid.Parse("019e1b45-9087-7c8f-a443-702b1d4c7f90"), }, { Guid.Parse("019e1b45-9087-7ab3-9217-c8942974763a"), Guid.Parse("019e1b45-9087-7475-80ac-03a67553d419"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7e04-9582-0d367ac3ca0e"), Guid.Parse("019e1b45-9087-78fc-8937-0a16a61e8128"), }, { Guid.Parse("019e1b45-9087-7e3f-ba57-f6da6b77cd88"), Guid.Parse("019e1b45-9087-7d8c-ae03-a10e26e02b32"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7c65-89ca-5beb502c4cab"), Guid.Parse("019e1b45-9087-7644-a7a4-a67c6aa17fea"), }, { Guid.Parse("019e1b45-9087-74a5-a6ac-d48c499d90a2"), Guid.Parse("019e1b45-9087-737f-b719-805ebb316218"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-706e-9219-e3e679192aa5"), Guid.Parse("019e1b45-9087-7a67-8de1-a3ff960a1dea"), }, { Guid.Parse("019e1b45-9087-7fbb-be6c-76a6ccfcae1d"), Guid.Parse("019e1b45-9087-7939-a14f-9aae71b56675"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7458-a9d4-7402d5181cb4"), Guid.Parse("019e1b45-9087-78b3-a04e-456a5b91c4d4"), }, { Guid.Parse("019e1b45-9087-7a1e-aa2c-06f19d3f96c3"), Guid.Parse("019e1b45-9087-79ff-988d-87c1c275e06c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7a9d-b915-788e922648fb"), Guid.Parse("019e1b45-9087-731d-98a9-1d7a7ecf7871"), }, { Guid.Parse("019e1b45-9087-73ea-aef1-5f0c2461b727"), Guid.Parse("019e1b45-9087-7ecd-8e74-2d1b0c3104a0"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 131,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-75ba-a8de-cf7d821ad99f"), Guid.Parse("019e1b45-9087-7237-9755-187314cff001"), }, { Guid.Parse("019e1b45-9087-7035-a2d9-eb5bb7832936"), Guid.Parse("019e1b45-9087-730c-8404-95c828cbb49b"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-77d0-851f-be0094066098"), Guid.Parse("019e1b45-9087-7185-8d4d-9c63cb3c647f"), }, { Guid.Parse("019e1b45-9087-7602-9221-1edece4e381b"), Guid.Parse("019e1b45-9087-7642-a601-101317e8686d"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-74a0-9e3a-3764fcad0446"), Guid.Parse("019e1b45-9087-7da0-9535-a515088a0470"), }, { Guid.Parse("019e1b45-9087-7f19-8f7e-6d8fe89f2f22"), Guid.Parse("019e1b45-9087-77e6-bcd6-d1378345c08a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-78d8-ba1b-2aaad1c9a440"), Guid.Parse("019e1b45-9087-7e99-9d7d-4796b67989b6"), }, { Guid.Parse("019e1b45-9087-7011-9256-b41c4d106719"), Guid.Parse("019e1b45-9087-7167-b062-890995fbc1fe"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-701e-869b-3299e0d760bf"), Guid.Parse("019e1b45-9087-7c4f-a64d-d18d768381af"), }, { Guid.Parse("019e1b45-9087-77bc-81d0-c4fa94ebf060"), Guid.Parse("019e1b45-9087-7a44-a0bb-316869f5518c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-76de-a96c-0836cfddca16"), Guid.Parse("019e1b45-9087-790f-aa69-1c178361faba"), }, { Guid.Parse("019e1b45-9087-7470-8672-1c5cc72760e7"), Guid.Parse("019e1b45-9087-7582-a7e9-d6e9a71b4486"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7c53-9269-6fe5292d5951"), Guid.Parse("019e1b45-9087-7a11-8f57-b2806e72e6be"), }, { Guid.Parse("019e1b45-9087-7648-be08-2cdff4a71b2b"), Guid.Parse("019e1b45-9087-7722-98da-7c65979b96ac"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7af6-a141-5fa588245dc6"), Guid.Parse("019e1b45-9087-702f-856c-75a585287ea9"), }, { Guid.Parse("019e1b45-9087-7f4f-beae-209976c4ea4a"), Guid.Parse("019e1b45-9087-7722-860a-70e3185c740f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-757b-b8b6-0a20a282eb96"), Guid.Parse("019e1b45-9087-7a30-91e0-43a6c3133436"), }, { Guid.Parse("019e1b45-9087-7971-a8ed-a736c08d7639"), Guid.Parse("019e1b45-9087-77e5-b0e1-afd10c433b81"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-731d-bd39-08a106b06db1"), Guid.Parse("019e1b45-9087-7679-aef7-999c13a5aa14"), }, { Guid.Parse("019e1b45-9087-7871-b644-46f94d5d5a2d"), Guid.Parse("019e1b45-9087-7c55-9d39-070cd5a0df14"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7d74-b811-0f1d3ee540c5"), Guid.Parse("019e1b45-9087-7d9b-b51c-69e0d91f8eb9"), }, { Guid.Parse("019e1b45-9087-77c3-b2a2-66a695853572"), Guid.Parse("019e1b45-9087-7aeb-8063-e5e96d2e0b7c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7ab1-86bd-8480d032e3a3"), Guid.Parse("019e1b45-9087-7a33-a094-d7b342e943c0"), }, { Guid.Parse("019e1b45-9087-7ebf-a759-903fb800a5da"), Guid.Parse("019e1b45-9087-774d-8d9d-117626d30b36"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7aca-8912-ec0302a219d7"), Guid.Parse("019e1b45-9087-74e2-ab08-add0d63307e3"), }, { Guid.Parse("019e1b45-9087-7a7a-8599-ae6b76bd6e96"), Guid.Parse("019e1b45-9087-7b3b-8acb-c91df4edd733"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 152,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7628-8eac-8b4ded9c896e"), Guid.Parse("019e1b45-9087-7972-acbb-d33c7d5032f4"), }, { Guid.Parse("019e1b45-9087-71d7-b5a6-db44c478bba1"), Guid.Parse("019e1b45-9087-7cc3-88c7-2e78b1d0db96"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7f3e-b912-f2ff53ad26c0"), Guid.Parse("019e1b45-9087-7cff-b207-bafff284a18f"), }, { Guid.Parse("019e1b45-9087-736b-b757-247b9a153b07"), Guid.Parse("019e1b45-9087-7a3d-bec7-5d7476b3b41e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7b2d-acff-9a9deb7259dd"), Guid.Parse("019e1b45-9087-74ba-b100-abff429d8274"), }, { Guid.Parse("019e1b45-9087-78b4-b14a-da44553d698d"), Guid.Parse("019e1b45-9087-7bd1-843d-1c81422bfba1"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 154,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-786c-b0d1-891787459653"), Guid.Parse("019e1b45-9087-72fc-ad90-a9c6600b76a6"), }, { Guid.Parse("019e1b45-9087-7f3c-b932-5f8a2f16387e"), Guid.Parse("019e1b45-9087-7030-a694-c552c1000e82"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9087-7910-90db-cba7c1e7055e"), Guid.Parse("019e1b45-9087-7873-b029-c357c2c5efd3"), }, { Guid.Parse("019e1b45-9087-7305-a1e7-f112a6c18b3b"), Guid.Parse("019e1b45-9087-7980-b4fb-10ed505629be"), }, },
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
INSERT INTO gedaqtests.guidv7marrayd2e1m(
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
FROM gedaqtests.guidv7marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7MArrayD2E1M)],
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
                    Guidv7MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    Guidv7MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

