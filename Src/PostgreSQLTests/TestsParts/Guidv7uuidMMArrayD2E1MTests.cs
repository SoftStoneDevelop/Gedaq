

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
    internal partial interface IGuidv7MArrayuuidMMArrayD2
    {
    }
    
    internal partial class Guidv7MArrayuuidMMArrayD2 : IGuidv7MArrayuuidMMArrayD2
    {


#region TestData

        private readonly Guidv7uuidMMArrayD2E1M[] _testData = new Guidv7uuidMMArrayD2E1M[]
        {
            new Guidv7uuidMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7bd2-8459-e223755c3f67"), Guid.Parse("019e1b50-1720-7cef-996e-2de612f25bae"), }, { Guid.Parse("019e1b50-1720-7627-a221-c7601357f97d"), Guid.Parse("019e1b50-1720-703b-aa1c-a7e543be6854"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7280-8452-7df785ef31c4"), Guid.Parse("019e1b50-1720-79ee-a4f4-2e9b43525b15"), }, { Guid.Parse("019e1b50-1720-7372-8644-4aa619dad9a5"), Guid.Parse("019e1b50-1720-77d1-aadb-3e88321242a2"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-752d-9b14-e41d99b6d383"), Guid.Parse("019e1b50-1720-709e-bdc8-e66c2c5f1921"), }, { Guid.Parse("019e1b50-1720-7148-b34f-51828dff91fc"), Guid.Parse("019e1b50-1720-7d71-954a-6025d732db8b"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7736-a28d-c545b0fb0e80"), Guid.Parse("019e1b50-1720-7f1e-b554-4883645d6588"), }, { Guid.Parse("019e1b50-1720-70f2-a990-2edf9de3d7cf"), Guid.Parse("019e1b50-1720-7bb2-9205-bed765bec64a"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7902-b7c9-525427f0daa1"), Guid.Parse("019e1b50-1720-7827-ac48-a1bff8e180f9"), }, { Guid.Parse("019e1b50-1720-715f-ab89-bbd58537bf30"), Guid.Parse("019e1b50-1720-7b19-826f-f39039b0f890"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-75a0-a495-6a3fc3a297d0"), Guid.Parse("019e1b50-1720-70f3-acaf-ee2ca758fdad"), }, { Guid.Parse("019e1b50-1720-7c7d-a823-db67822676e2"), Guid.Parse("019e1b50-1720-7148-8790-f26a231e5b96"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7c79-b2a0-421bef908bda"), Guid.Parse("019e1b50-1720-704a-b253-6665627bd410"), }, { Guid.Parse("019e1b50-1720-702d-8a0b-1c9bf9f92794"), Guid.Parse("019e1b50-1720-7d45-a183-6a9c2b772f4f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7bd4-a58d-3ea8c276b46e"), Guid.Parse("019e1b50-1720-7240-abcf-5fcf78a1bdc3"), }, { Guid.Parse("019e1b50-1720-75f9-88b1-9d7250174295"), Guid.Parse("019e1b50-1720-75ad-8488-a196f94dbb79"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7652-8981-7f13c8990455"), Guid.Parse("019e1b50-1720-7e0d-909c-296d8b52cb2e"), }, { Guid.Parse("019e1b50-1720-7077-a8d9-661863d54c28"), Guid.Parse("019e1b50-1720-7c82-a266-eabc338a7f8c"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7de9-8302-7e4a9100b4d8"), Guid.Parse("019e1b50-1720-7d6c-80e9-17f5323d0797"), }, { Guid.Parse("019e1b50-1720-7fd7-b686-ff08bf8ebf92"), Guid.Parse("019e1b50-1720-7f59-b729-eb921ba6ff19"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7edc-9f1e-8f4d9179d95c"), Guid.Parse("019e1b50-1720-7fca-aea8-4bcccd2e4d1c"), }, { Guid.Parse("019e1b50-1720-7015-a351-6b736031a5f2"), Guid.Parse("019e1b50-1720-7889-bb1a-66b5846c9d23"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-78a9-8bac-ab9a311efc8b"), Guid.Parse("019e1b50-1720-7603-b1ad-81614286565d"), }, { Guid.Parse("019e1b50-1720-7bda-b1ae-a952cc6003e5"), Guid.Parse("019e1b50-1720-7e9c-ba09-49b7e64992e5"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-78fd-b641-ee481feff55b"), Guid.Parse("019e1b50-1720-7fee-aa57-c081e4a70034"), }, { Guid.Parse("019e1b50-1720-7280-8a7a-da42e11fd75d"), Guid.Parse("019e1b50-1720-7600-9707-51ce82d8df64"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7761-9ad3-2e99bd057f40"), Guid.Parse("019e1b50-1720-7671-b34e-7e4fdea08b24"), }, { Guid.Parse("019e1b50-1720-7c8f-ae41-14374f5c31d5"), Guid.Parse("019e1b50-1720-7828-8c16-4f42d0bee4d4"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-708d-b61b-23633bb50ef2"), Guid.Parse("019e1b50-1720-7c1d-a75a-6db29db98324"), }, { Guid.Parse("019e1b50-1720-758a-9885-590739cbd223"), Guid.Parse("019e1b50-1720-72f2-af19-78708b20d486"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-79cd-9658-87c394399d48"), Guid.Parse("019e1b50-1720-7779-8af3-4d9760763f37"), }, { Guid.Parse("019e1b50-1720-71cf-afd5-6703888c972c"), Guid.Parse("019e1b50-1720-7466-85b0-d5218daf4420"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7ae5-9743-aa1c550532e0"), Guid.Parse("019e1b50-1720-7bf2-a18d-84c3cd477bdc"), }, { Guid.Parse("019e1b50-1720-7d2f-9ae7-f0e5b7d480cf"), Guid.Parse("019e1b50-1720-71e0-9ed9-0dbd23d52ffc"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7a74-80a0-6adf3bfb759d"), Guid.Parse("019e1b50-1720-7374-8a05-58c18922e484"), }, { Guid.Parse("019e1b50-1720-7f38-8968-7fa1d2baa739"), Guid.Parse("019e1b50-1720-735c-b446-90e1df9c3121"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-716b-b38a-8fb7816acac6"), Guid.Parse("019e1b50-1720-778e-99ea-3f74ec10bece"), }, { Guid.Parse("019e1b50-1720-7bcb-b0c3-bcbed27ee320"), Guid.Parse("019e1b50-1720-7f6a-9e9b-2a6786eacdf3"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7c20-b713-f0561142056d"), Guid.Parse("019e1b50-1720-7591-880d-09d7a3e5dbd3"), }, { Guid.Parse("019e1b50-1720-7230-b788-283a2d1f1a95"), Guid.Parse("019e1b50-1720-793a-87f0-50f54f809ed7"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7c2e-986f-f9b98bd8c44c"), Guid.Parse("019e1b50-1720-7057-8585-2f064cb27469"), }, { Guid.Parse("019e1b50-1720-7cad-b4fb-bda643f368e2"), Guid.Parse("019e1b50-1720-774d-aa9a-f52150d35c50"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-71d5-bc31-2c2d51e7766c"), Guid.Parse("019e1b50-1720-79bc-94e0-a9062fe7a535"), }, { Guid.Parse("019e1b50-1720-7067-b225-22a014613d6b"), Guid.Parse("019e1b50-1720-7b24-9af3-c0fbd406d9ea"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-79c1-bd5a-44ecd7f81d89"), Guid.Parse("019e1b50-1720-768e-a208-355579fb53e1"), }, { Guid.Parse("019e1b50-1720-7feb-b491-34af5273c02a"), Guid.Parse("019e1b50-1720-7745-b6e9-af091e78b863"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-704d-a36d-31c87d923ca2"), Guid.Parse("019e1b50-1720-7afa-bb63-d8c750196629"), }, { Guid.Parse("019e1b50-1720-763e-b7d0-2ab7d5100133"), Guid.Parse("019e1b50-1720-7ea1-a62a-6bfca9bf2382"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7414-b63b-6c7ec7f2cbe8"), Guid.Parse("019e1b50-1720-7b32-b4db-9f94a0612164"), }, { Guid.Parse("019e1b50-1720-7e90-87cc-9a72fe9ca2c8"), Guid.Parse("019e1b50-1720-763b-8a14-99f6d07bc998"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-745e-8a64-41be327a6459"), Guid.Parse("019e1b50-1720-72b2-9e77-fb89f3846f7f"), }, { Guid.Parse("019e1b50-1720-73a3-b167-57f55d43cd10"), Guid.Parse("019e1b50-1720-76f6-acdf-f645a9872b91"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-786b-90eb-40963b905bc9"), Guid.Parse("019e1b50-1720-717c-b776-c3ea2291d026"), }, { Guid.Parse("019e1b50-1720-76d7-aa99-f46daa904ac3"), Guid.Parse("019e1b50-1720-70d1-a93f-ed8f512bc933"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-763d-bb47-599416b52462"), Guid.Parse("019e1b50-1720-776a-ad27-91a8dd1c19c8"), }, { Guid.Parse("019e1b50-1720-7932-8d07-d1dfcc866445"), Guid.Parse("019e1b50-1720-7a5e-a977-f77151ca9db6"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-77a8-9514-9761829e0ed6"), Guid.Parse("019e1b50-1720-7098-93ba-282aab81b4a7"), }, { Guid.Parse("019e1b50-1720-7f0b-a987-9d6b8a2b27ad"), Guid.Parse("019e1b50-1720-7190-bfa5-28367ac2d694"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-73da-981e-d893e274f789"), Guid.Parse("019e1b50-1720-751c-9c97-3cd37a13fbe7"), }, { Guid.Parse("019e1b50-1720-7e3a-963d-d75f4c181d10"), Guid.Parse("019e1b50-1720-7388-8026-d8dc28b3c8b2"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7757-9427-32329ba0e966"), Guid.Parse("019e1b50-1720-7871-858c-ed2440a28f30"), }, { Guid.Parse("019e1b50-1720-75e8-b6d7-210c7c616d90"), Guid.Parse("019e1b50-1720-7918-acb6-8301521d664f"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-700b-84e7-1b3cfbc9e370"), Guid.Parse("019e1b50-1720-7bac-b8f3-550cbf9e3a6d"), }, { Guid.Parse("019e1b50-1720-7926-989f-057108ea9e92"), Guid.Parse("019e1b50-1720-7935-8160-9d9c7d7db904"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7a85-81f1-33ee3f466ec5"), Guid.Parse("019e1b50-1720-7633-a9b7-822c1196d999"), }, { Guid.Parse("019e1b50-1720-7360-8aad-8ccb4f0b0fcb"), Guid.Parse("019e1b50-1720-719c-9f98-5faa6ad14afd"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7af6-85d1-140197255d46"), Guid.Parse("019e1b50-1720-7d63-9aee-cf7eb8d1226f"), }, { Guid.Parse("019e1b50-1720-7a5e-a0a4-c68dc7f0b641"), Guid.Parse("019e1b50-1720-73fc-b63a-544df0ddd0ec"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7fec-9b31-1f997b3b9e23"), Guid.Parse("019e1b50-1720-74d6-b828-2723d3171c52"), }, { Guid.Parse("019e1b50-1720-721c-9e80-edaef7284bbf"), Guid.Parse("019e1b50-1720-7365-b619-d541a2b714ae"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-746b-8d61-7738fb9917f9"), Guid.Parse("019e1b50-1720-7807-9075-e35e29f3a16c"), }, { Guid.Parse("019e1b50-1720-7596-a986-59f0dc7858b7"), Guid.Parse("019e1b50-1720-7514-b790-a9355809f5b6"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7462-a97f-be153efe716b"), Guid.Parse("019e1b50-1720-7229-8d6d-5eab34d4e3d5"), }, { Guid.Parse("019e1b50-1720-7916-a161-f8e54ab16ed2"), Guid.Parse("019e1b50-1720-7f0d-a3a9-fb3e1d8e541c"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7abf-ac23-4d73062cdb1f"), Guid.Parse("019e1b50-1720-77f3-97b7-e70e82330b07"), }, { Guid.Parse("019e1b50-1720-71bd-b50e-1c114f0feb08"), Guid.Parse("019e1b50-1720-749a-bfed-068cc8d819e2"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7229-9386-e019b016b36d"), Guid.Parse("019e1b50-1720-725e-a5c5-356db58b9e23"), }, { Guid.Parse("019e1b50-1720-74e0-afa0-b19cd0509733"), Guid.Parse("019e1b50-1720-796e-8f57-7f5bff789fe7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7ce8-8aef-58fe1a9c9375"), Guid.Parse("019e1b50-1720-78b9-9ee7-7912780d6136"), }, { Guid.Parse("019e1b50-1720-7a7c-aa0d-a305ace84d29"), Guid.Parse("019e1b50-1720-73f5-bb9e-67b5a5c01877"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7914-b927-9ffa8bcef2dc"), Guid.Parse("019e1b50-1720-73bd-a773-9801fd66ffa8"), }, { Guid.Parse("019e1b50-1720-75e2-90b5-d8a54c8f9555"), Guid.Parse("019e1b50-1720-7249-a8fd-d6f84a9d5598"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-76b5-9240-b88f11a13897"), Guid.Parse("019e1b50-1720-7b8c-806f-fb7b043baff7"), }, { Guid.Parse("019e1b50-1720-7776-a4c5-c9e81260aec4"), Guid.Parse("019e1b50-1720-7093-b26b-d406e224722a"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-76c1-b8c9-aeb5093f1664"), Guid.Parse("019e1b50-1720-752b-85d8-3faf9f3ee653"), }, { Guid.Parse("019e1b50-1720-7f77-b9b8-b9184597ce1e"), Guid.Parse("019e1b50-1720-70ef-8579-8243e2884e22"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-73bb-a61a-4baa087aca1d"), Guid.Parse("019e1b50-1720-771c-944b-924f7cd0fee7"), }, { Guid.Parse("019e1b50-1720-78de-b54a-6bd25212d657"), Guid.Parse("019e1b50-1720-7ed4-a357-50215b4c8095"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7193-9e4b-d47d4307a1c6"), Guid.Parse("019e1b50-1720-74fe-9e82-5d9df3d65495"), }, { Guid.Parse("019e1b50-1720-7391-bce5-237b22818323"), Guid.Parse("019e1b50-1720-79ca-949d-6a87b395a52e"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7fb2-88b7-03ff152692b2"), Guid.Parse("019e1b50-1720-7e6e-8bf3-bfb23149489a"), }, { Guid.Parse("019e1b50-1720-7581-8a3b-cfffd8706be9"), Guid.Parse("019e1b50-1720-75c7-bbaf-c16d78b3fce2"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-79e3-93eb-cd3e12fe1594"), Guid.Parse("019e1b50-1720-7216-9000-cc4ba64bff6e"), }, { Guid.Parse("019e1b50-1720-7575-8dda-28287b1761d8"), Guid.Parse("019e1b50-1720-7e41-886f-e546e8b966ec"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7401-8008-2371e42d9fc0"), Guid.Parse("019e1b50-1720-768b-8eb9-84f73f4fc314"), }, { Guid.Parse("019e1b50-1720-76e5-addb-578276813061"), Guid.Parse("019e1b50-1720-78ff-bdbf-5796e0a7843a"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7b3e-8c15-6dbb00b07d8a"), Guid.Parse("019e1b50-1720-7521-8e07-1621eda53c41"), }, { Guid.Parse("019e1b50-1720-774b-b140-6249c60a7995"), Guid.Parse("019e1b50-1720-7cc5-b288-bb378fa46772"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7436-9363-88654ffd3315"), Guid.Parse("019e1b50-1720-706f-82da-0fab28207d30"), }, { Guid.Parse("019e1b50-1720-7b73-b522-daae84bdd519"), Guid.Parse("019e1b50-1720-7e72-8b84-14813201c07f"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7219-b618-d685c791c1cc"), Guid.Parse("019e1b50-1720-7e3c-8f5d-98acdfd5a566"), }, { Guid.Parse("019e1b50-1720-7fe6-b55e-a25e7139b432"), Guid.Parse("019e1b50-1720-70f8-a449-fdc59a14d591"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-70c0-99d8-10db48995099"), Guid.Parse("019e1b50-1720-75db-ae9f-3dadb4cbda44"), }, { Guid.Parse("019e1b50-1720-74bf-8a00-07788efa4b11"), Guid.Parse("019e1b50-1720-7032-9a82-1e2ce80bef28"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7eca-8ab8-535903551dde"), Guid.Parse("019e1b50-1720-741d-a5e9-a4b718b330af"), }, { Guid.Parse("019e1b50-1720-730d-a31d-caedb753be38"), Guid.Parse("019e1b50-1720-7591-a4ed-164c55e75235"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7297-982c-e94e046068b7"), Guid.Parse("019e1b50-1720-7d13-8717-c2285d66900d"), }, { Guid.Parse("019e1b50-1720-752d-9676-aca32bb05970"), Guid.Parse("019e1b50-1721-71d6-884f-1f3520b24578"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-71ad-b7f1-ddced2249df0"), Guid.Parse("019e1b50-1721-70b9-929f-ad910628e466"), }, { Guid.Parse("019e1b50-1721-7b3a-a333-5c5f2f5e242d"), Guid.Parse("019e1b50-1721-7517-833f-8d8a75462265"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-76a4-999f-7eac28fb8a8b"), Guid.Parse("019e1b50-1721-7fa8-a313-2a5f940ba538"), }, { Guid.Parse("019e1b50-1721-76ad-aeeb-92ed0542e22a"), Guid.Parse("019e1b50-1721-71ed-afc9-dd81ef22c1c2"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-71d9-9300-0eeecc29aa08"), Guid.Parse("019e1b50-1721-71fc-987d-de478ad883d7"), }, { Guid.Parse("019e1b50-1721-761c-9983-8df71cd66c45"), Guid.Parse("019e1b50-1721-710a-a27c-d0bf56c31d49"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7909-8aaa-d00dc4d86764"), Guid.Parse("019e1b50-1721-7a58-a66a-e2c619b7f0b5"), }, { Guid.Parse("019e1b50-1721-7f1c-8532-3cb2dad6dd28"), Guid.Parse("019e1b50-1721-7c52-b2ae-615fdd7140de"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7b9d-a222-0313cb823dd2"), Guid.Parse("019e1b50-1721-7612-9967-f1e5698127ea"), }, { Guid.Parse("019e1b50-1721-719d-9a4b-e11bdfa7187f"), Guid.Parse("019e1b50-1721-7c1a-9090-2c13a6203909"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7337-a4ca-15a235ca2e26"), Guid.Parse("019e1b50-1721-75cb-8145-24a6d6475aa9"), }, { Guid.Parse("019e1b50-1721-78a2-aed3-4e70e141fde2"), Guid.Parse("019e1b50-1721-7495-a012-bd2691ca4403"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7ca4-8de9-ae24022e266e"), Guid.Parse("019e1b50-1721-76f9-b240-a028c92a50ce"), }, { Guid.Parse("019e1b50-1721-7414-84c7-2692f4aaa718"), Guid.Parse("019e1b50-1721-7b1a-859e-7658d05c0934"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7c9d-82de-bab037cb3825"), Guid.Parse("019e1b50-1721-7ed4-9f7b-f9c8ce65d2dc"), }, { Guid.Parse("019e1b50-1721-7b45-96a9-53190b989ded"), Guid.Parse("019e1b50-1721-7a6c-9995-edfecf42f6f4"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-769c-8392-41d7dc53474f"), Guid.Parse("019e1b50-1721-7b0c-aedb-1b6120af358d"), }, { Guid.Parse("019e1b50-1721-7bd1-b48a-56934d4926b7"), Guid.Parse("019e1b50-1721-705e-8fee-72fd1fff4d7b"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7919-8996-e03cbeea57c3"), Guid.Parse("019e1b50-1721-7ca0-9cb4-85199ec0ce82"), }, { Guid.Parse("019e1b50-1721-7ded-bb1c-cbbd14b9e0d9"), Guid.Parse("019e1b50-1721-7ee5-8b6e-f61e0778c101"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7a41-9b71-07ba88228f90"), Guid.Parse("019e1b50-1721-72da-89ae-bca77173d379"), }, { Guid.Parse("019e1b50-1721-7fa7-98bd-371118ac01ce"), Guid.Parse("019e1b50-1721-7b20-89ee-020ae21ed1f7"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7bdb-8ed9-f0a42474b8cd"), Guid.Parse("019e1b50-1721-7332-b5d6-7174818deb90"), }, { Guid.Parse("019e1b50-1721-7b84-bbb6-b57e415dac6d"), Guid.Parse("019e1b50-1721-7e9b-944e-8efd6043ffe6"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7e61-a1ba-8ba1c9844c46"), Guid.Parse("019e1b50-1721-771d-9431-7807a02ffaf9"), }, { Guid.Parse("019e1b50-1721-79e4-859b-c5d313ef894e"), Guid.Parse("019e1b50-1721-74be-aeba-a66ff70ae6cd"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7cff-ab27-fb93cc26e987"), Guid.Parse("019e1b50-1721-72e4-9262-e31ff7e7165b"), }, { Guid.Parse("019e1b50-1721-7b4d-84b1-aa3b1e5df403"), Guid.Parse("019e1b50-1721-71f2-aab3-23f2a05d6a23"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7233-8636-1ad4eaf0024b"), Guid.Parse("019e1b50-1721-72f2-a02c-5374d134d9d0"), }, { Guid.Parse("019e1b50-1721-7c08-9c66-028bba9c869f"), Guid.Parse("019e1b50-1721-77f9-a401-b8cb1622a304"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-71c1-9a36-7707cc511bd7"), Guid.Parse("019e1b50-1721-7d7a-811b-27f8ff3d909e"), }, { Guid.Parse("019e1b50-1721-7127-9025-d362c6c5e601"), Guid.Parse("019e1b50-1721-7561-9668-75c9a80420aa"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7039-8715-785db2b68738"), Guid.Parse("019e1b50-1721-72f5-b9cc-8cafbeaa43aa"), }, { Guid.Parse("019e1b50-1721-7fcc-9b25-c715d08365b9"), Guid.Parse("019e1b50-1721-744f-9287-bcf2f1ebe074"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7022-aa5b-63912687a256"), Guid.Parse("019e1b50-1721-75c6-9389-859cacaf54f5"), }, { Guid.Parse("019e1b50-1721-7a44-bfe6-0505f44805e8"), Guid.Parse("019e1b50-1721-7d85-8e77-9ad86f199bf5"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7cdb-8ca7-00120591db28"), Guid.Parse("019e1b50-1721-7976-8935-22816ffd7f19"), }, { Guid.Parse("019e1b50-1721-79df-ba09-3a6664b5f8c9"), Guid.Parse("019e1b50-1721-7742-89d8-85adfb53b869"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7b3c-a889-d3c991508ffe"), Guid.Parse("019e1b50-1721-709f-a990-3ee012cbbe87"), }, { Guid.Parse("019e1b50-1721-7b07-81ea-e40e23e88388"), Guid.Parse("019e1b50-1721-7216-9a4a-b7a49a7a99f4"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7f1c-a79f-06b1677d534f"), Guid.Parse("019e1b50-1721-724b-8e44-6f57d036a21b"), }, { Guid.Parse("019e1b50-1721-71d2-b696-9d576f68b81f"), Guid.Parse("019e1b50-1721-7ead-94d8-f7688ef7f428"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-79bb-acda-d8a4ea1d6007"), Guid.Parse("019e1b50-1721-750d-9cd7-cee81097317d"), }, { Guid.Parse("019e1b50-1721-7ef6-8e27-11cf5b8bb66c"), Guid.Parse("019e1b50-1721-783e-a721-6f9871b268b9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7936-a688-fe45b55aebe5"), Guid.Parse("019e1b50-1721-7726-8215-61aa5d3b34f1"), }, { Guid.Parse("019e1b50-1721-714d-8ff4-3049172aed4f"), Guid.Parse("019e1b50-1721-72dc-8030-053559b61966"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-1721-7421-9299-bcf9876105a4"), Guid.Parse("019e1b50-1721-764f-966a-0d3e8643c6c1"), }, { Guid.Parse("019e1b50-1721-74af-b17d-50552d786da8"), Guid.Parse("019e1b50-1721-7539-bae7-7d1810d125a9"), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
INSERT INTO public.guidv7uuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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

                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)), 
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
                methodParametrName: "guidv7uuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd2e1mi_id
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
    guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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

                    nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b50-1720-78fd-b641-ee481feff55b"), Guid.Parse("019e1b50-1720-7fee-aa57-c081e4a70034"), }, { Guid.Parse("019e1b50-1720-7280-8a7a-da42e11fd75d"), Guid.Parse("019e1b50-1720-7600-9707-51ce82d8df64"), }, }));
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

                    nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b50-1720-708d-b61b-23633bb50ef2"), Guid.Parse("019e1b50-1720-7c1d-a75a-6db29db98324"), }, { Guid.Parse("019e1b50-1720-758a-9885-590739cbd223"), Guid.Parse("019e1b50-1720-72f2-af19-78708b20d486"), }, }));
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

                    nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7a74-80a0-6adf3bfb759d"), Guid.Parse("019e1b50-1720-7374-8a05-58c18922e484"), }, { Guid.Parse("019e1b50-1720-7f38-8968-7fa1d2baa739"), Guid.Parse("019e1b50-1720-735c-b446-90e1df9c3121"), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd2e1mi_id
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
    guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                methodParametrName: "guidv7uuidmmarrayd2e1mi_id", 
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
                nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b50-1720-7c20-b713-f0561142056d"), Guid.Parse("019e1b50-1720-7591-880d-09d7a3e5dbd3"), }, { Guid.Parse("019e1b50-1720-7230-b788-283a2d1f1a95"), Guid.Parse("019e1b50-1720-793a-87f0-50f54f809ed7"), }, }));
                nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b50-1720-79c1-bd5a-44ecd7f81d89"), Guid.Parse("019e1b50-1720-768e-a208-355579fb53e1"), }, { Guid.Parse("019e1b50-1720-7feb-b491-34af5273c02a"), Guid.Parse("019e1b50-1720-7745-b6e9-af091e78b863"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD2E1M> models = null;

                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD2E1M> models = null;

                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 31, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 45, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 152, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 104, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IGuidv7MArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidv7MArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidv7MArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidv7MArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((IGuidv7MArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MI),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1M),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
FROM public.binary_guidv7uuidmmarrayd2e1m m
LEFT JOIN public.binary_guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models =  ((IGuidv7MArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA), typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA), typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI), typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MI>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MI>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA), typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

