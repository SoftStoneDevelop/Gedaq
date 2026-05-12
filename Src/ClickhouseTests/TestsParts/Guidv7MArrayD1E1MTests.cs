

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

        private readonly Guidv7MArrayD1E1M[] _testData = new Guidv7MArrayD1E1M[]
        {
            new Guidv7MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7da4-945e-b1617a88afcb"),
Guid.Parse("019e1b45-9084-796e-a215-2790752d95da"),
Guid.Parse("019e1b45-9084-74b0-b290-8e566c608fa7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-77a5-9901-c62ae38fbc2d"),
Guid.Parse("019e1b45-9084-7e8f-b8c1-68150fa4a9c8"),
Guid.Parse("019e1b45-9084-742b-8a57-b3fecbf214d9"),
Guid.Parse("019e1b45-9084-7154-ab5d-b67bc0ee2d51"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-77a0-80c4-53aebef97032"),
Guid.Parse("019e1b45-9084-7c37-8c30-d06fb1f6e8e6"),
Guid.Parse("019e1b45-9084-79be-aa56-299eaddb4cf8"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7133-8fbe-edbce4797cc3"),
Guid.Parse("019e1b45-9084-7d38-9b48-a4f867148f4d"),
Guid.Parse("019e1b45-9084-76b1-ab2c-2b450103afaa"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7407-8748-85eb9a36d61d"),
Guid.Parse("019e1b45-9084-778a-9a77-5943cbade46c"),
Guid.Parse("019e1b45-9084-7248-8fdf-5b0c98e9d24f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-73c0-9a5b-a0a4d777c4eb"),
Guid.Parse("019e1b45-9084-7d10-b136-0afed9343307"),
Guid.Parse("019e1b45-9084-782b-8f45-47733ee486ef"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-74b8-926b-4c638331331e"),
Guid.Parse("019e1b45-9084-704c-9b74-9b3b7204bf03"),
Guid.Parse("019e1b45-9084-748b-9b8c-4e610c53fea5"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-72ea-8377-7bc8524cb356"),
Guid.Parse("019e1b45-9084-7bda-b392-599e59a65e56"),
Guid.Parse("019e1b45-9084-7b20-81e2-3bf9f4aa447f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-71df-9f1b-9bf73277472b"),
Guid.Parse("019e1b45-9084-7234-92f7-d9bfd09b43e0"),
Guid.Parse("019e1b45-9084-73c2-a8ed-da9ab4c433a0"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7c9b-8e1f-89edb2b34e8e"),
Guid.Parse("019e1b45-9084-7e1e-9873-7c3f4eba7c40"),
Guid.Parse("019e1b45-9084-72ba-a42e-1391dbcd1624"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-776d-a56d-8a0d7b8538d0"),
Guid.Parse("019e1b45-9084-78b9-b234-961a4eeb6dae"),
Guid.Parse("019e1b45-9084-7080-a085-5a0a9ce3068a"),
Guid.Parse("019e1b45-9084-70d7-af13-0da0e4df2b25"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-70dc-a492-045094936b69"),
Guid.Parse("019e1b45-9084-7a6c-9194-a91386e07796"),
Guid.Parse("019e1b45-9084-7d81-8a86-dfab659c6281"),
Guid.Parse("019e1b45-9084-7577-94ad-9e1c2062af8d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7d37-9975-de45f14084e4"),
Guid.Parse("019e1b45-9084-7dfc-af2c-5676a1198a3f"),
Guid.Parse("019e1b45-9084-73a0-8a81-7323215d15ac"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7666-a000-2a493f7f6e18"),
Guid.Parse("019e1b45-9084-75b3-9012-8a92bb7f1b2f"),
Guid.Parse("019e1b45-9084-73f8-8bdd-8cb1080192bc"),
Guid.Parse("019e1b45-9084-70a0-8f82-e1be5a22a648"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-739b-a1f1-a60ab1b0dd1f"),
Guid.Parse("019e1b45-9084-7884-a242-b502675c02f0"),
Guid.Parse("019e1b45-9084-7935-945a-6dc8b59c4ec6"),
Guid.Parse("019e1b45-9084-7a5e-8ed4-c7b83e16324a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7f60-bcf6-eb5b4e8be06d"),
Guid.Parse("019e1b45-9084-7a4f-95ee-d9027854fec2"),
Guid.Parse("019e1b45-9084-7838-81d9-178982c8c137"),
Guid.Parse("019e1b45-9084-78c7-a201-cd8360942ae3"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-79b4-b87b-43bb82af9e4a"),
Guid.Parse("019e1b45-9084-7b1e-99f9-c87b08372da6"),
Guid.Parse("019e1b45-9084-7a15-9fb7-74bd678b1803"),
Guid.Parse("019e1b45-9084-7b20-96f7-217f1d8dfa30"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7aa3-a142-d73f21d62310"),
Guid.Parse("019e1b45-9084-7f6d-a805-7f6c7563eb0e"),
Guid.Parse("019e1b45-9084-7f54-913b-3e9debeea034"),
Guid.Parse("019e1b45-9084-7f53-af50-1390bc0f3949"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-74f7-af5c-8f87d854ef30"),
Guid.Parse("019e1b45-9084-74fd-aa64-60dd313fbdc1"),
Guid.Parse("019e1b45-9084-77b6-a421-97037859e044"),
Guid.Parse("019e1b45-9084-767a-8f50-5fac6602a671"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-786c-8d97-6355c139b81d"),
Guid.Parse("019e1b45-9084-796c-ac85-f08e77c54959"),
Guid.Parse("019e1b45-9084-7e1d-a0bf-5257f6fb9c7e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7c33-a440-71c3604cd438"),
Guid.Parse("019e1b45-9084-73db-b06f-1e79174e87b5"),
Guid.Parse("019e1b45-9084-7db0-8191-9fa2e00d21aa"),
Guid.Parse("019e1b45-9084-7b8a-a5be-c50f8d4c814b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7d6e-b928-f32f3634ddc6"),
Guid.Parse("019e1b45-9084-7cee-847d-9fa70e4dc803"),
Guid.Parse("019e1b45-9084-723f-8878-d7260b5caba1"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7d94-b260-296e36c6c079"),
Guid.Parse("019e1b45-9084-7028-8f8b-1f88604ce3f9"),
Guid.Parse("019e1b45-9084-752d-b3f3-952cba20ce8c"),
Guid.Parse("019e1b45-9084-779d-8926-f299a187b4f3"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-72e5-89cd-dd551a0ad053"),
Guid.Parse("019e1b45-9084-7bda-acb9-cdef71817dfb"),
Guid.Parse("019e1b45-9084-7ed9-87e1-6424d9c61b7e"),
Guid.Parse("019e1b45-9084-7bd9-87f2-41baff8fe3f8"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7222-96a9-647f74a774a4"),
Guid.Parse("019e1b45-9084-75b0-a82a-16b6b2d47e34"),
Guid.Parse("019e1b45-9084-7d43-a4c9-cc07a86e1d8d"),
Guid.Parse("019e1b45-9084-7542-9029-21b52f36ed3a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7ff3-9e4a-3f1c9884644f"),
Guid.Parse("019e1b45-9084-7d72-bfa4-6269b3da4aa8"),
Guid.Parse("019e1b45-9084-7b36-96d0-0d27f8910446"),
Guid.Parse("019e1b45-9084-7ccb-a570-438543e0fae6"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-707c-8069-60f4f7742879"),
Guid.Parse("019e1b45-9084-7443-b538-4a6848a4c0a2"),
Guid.Parse("019e1b45-9084-77ee-8d95-0d470240d727"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-70c0-be1e-da77eb7411a1"),
Guid.Parse("019e1b45-9084-7ebf-a1ce-131039644612"),
Guid.Parse("019e1b45-9084-7547-9c0d-1bf241a9ed22"),
Guid.Parse("019e1b45-9084-7eb7-9499-4c061e133f26"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7e05-86a2-2e88e806f289"),
Guid.Parse("019e1b45-9084-77ee-8814-8c67aeae5d70"),
Guid.Parse("019e1b45-9084-7808-aae9-06fdd6912b40"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-76d0-9514-35dab9fb7a8b"),
Guid.Parse("019e1b45-9084-7401-a935-3d5b1c9ecb5b"),
Guid.Parse("019e1b45-9084-7803-9222-035ea8eb0e48"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7288-8f8b-c34e4313e68e"),
Guid.Parse("019e1b45-9084-775b-aaae-a8106be97886"),
Guid.Parse("019e1b45-9084-7c96-bb62-b7e020066f15"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7e82-a67c-403efe2c9e7e"),
Guid.Parse("019e1b45-9084-7cac-803b-3db9770f9fa0"),
Guid.Parse("019e1b45-9084-7712-b90d-3de9e44e83e8"),
Guid.Parse("019e1b45-9084-7937-8f0e-4cbcc6e42f24"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-76e3-8fc9-de5d1646bfd2"),
Guid.Parse("019e1b45-9084-71fb-9e5a-c7c3eccbb8f2"),
Guid.Parse("019e1b45-9084-7bd1-a8d6-d12dcb471e37"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7e61-981e-db35ed8dc2e9"),
Guid.Parse("019e1b45-9084-773a-9ba7-77b7a54be5cd"),
Guid.Parse("019e1b45-9084-78f9-9437-473044171964"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7fd1-9e08-beda444b66c0"),
Guid.Parse("019e1b45-9084-7fc0-8ed9-01864cc94b77"),
Guid.Parse("019e1b45-9084-7e31-a659-844d1fb19ebd"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7c7a-80fc-51e96cf05cfd"),
Guid.Parse("019e1b45-9084-7a35-81ca-e095e92db057"),
Guid.Parse("019e1b45-9084-702d-b8b7-f326c627b346"),
Guid.Parse("019e1b45-9084-7217-8092-226ad6c24896"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7c89-9c2b-27dcbc312bd6"),
Guid.Parse("019e1b45-9084-7fb1-a18c-9306bc4ea97b"),
Guid.Parse("019e1b45-9084-76ef-b142-63c0e2fea417"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-71ad-ad1b-23d9af0c053e"),
Guid.Parse("019e1b45-9084-7470-9e86-7410fa3b0eec"),
Guid.Parse("019e1b45-9084-7812-97ed-a9429d4056ab"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7b89-a5c6-7514bee003a6"),
Guid.Parse("019e1b45-9084-70c4-bbaf-4b22d744c3c3"),
Guid.Parse("019e1b45-9084-7229-970c-b2e8ac8cb0de"),
Guid.Parse("019e1b45-9084-7cde-894a-043c56420359"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7d3b-9211-3aa046b209cf"),
Guid.Parse("019e1b45-9084-7fc3-a47d-5d8990ed08f2"),
Guid.Parse("019e1b45-9084-7cbb-bb0f-0810c58a6abf"),
Guid.Parse("019e1b45-9084-71b1-930b-78894ca5121f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-710b-a69a-a4dca6545f7c"),
Guid.Parse("019e1b45-9084-76bb-8bfd-c5c0da3e43d6"),
Guid.Parse("019e1b45-9084-7b92-b878-c70cf59c5627"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7d36-9702-d42d371c1c4e"),
Guid.Parse("019e1b45-9084-7e7e-b497-4f662e44cfc2"),
Guid.Parse("019e1b45-9084-7a7c-8e00-dd9fec672aab"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-76c7-8c57-ca7b21831082"),
Guid.Parse("019e1b45-9084-7268-bbca-424689d07f7d"),
Guid.Parse("019e1b45-9084-7048-8ca8-c5951842eb06"),
Guid.Parse("019e1b45-9084-72b4-b158-145cdf04d5eb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7e88-a664-7b7437ee0acf"),
Guid.Parse("019e1b45-9084-75bb-8777-5213072ab339"),
Guid.Parse("019e1b45-9084-7a22-b2c6-790cc9d2ba23"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7f36-a925-d81da073bf4c"),
Guid.Parse("019e1b45-9084-787e-b511-ef2d0542643e"),
Guid.Parse("019e1b45-9084-7e73-a4e2-4a13dbc4bb9b"),
Guid.Parse("019e1b45-9084-704b-9fe8-87576dc4c93b"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 94,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7c4e-8c6c-ded8bc619fb0"),
Guid.Parse("019e1b45-9084-71c6-9990-e01b5556c935"),
Guid.Parse("019e1b45-9084-784f-9c9b-4acfc6b4f45d"),
Guid.Parse("019e1b45-9084-7828-a70c-f4e2cb3ca39d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-762b-bf09-a8715cfc8a92"),
Guid.Parse("019e1b45-9084-7eb7-9bd3-73ae3f2419e4"),
Guid.Parse("019e1b45-9084-7b27-b66d-f5bcdfc74ece"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7dfa-a9cd-87868540f7b9"),
Guid.Parse("019e1b45-9084-7568-9e0f-e49fe0218003"),
Guid.Parse("019e1b45-9084-7bfe-9161-55e00830db9a"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7ab6-98df-11fab5f18176"),
Guid.Parse("019e1b45-9084-7cff-a629-dc5cfcc8028f"),
Guid.Parse("019e1b45-9084-7c38-b93e-c5cfa34becf0"),
Guid.Parse("019e1b45-9084-7e91-b155-1a3e36beb893"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-74f5-a7fb-e3a898b65c97"),
Guid.Parse("019e1b45-9084-7344-a2e1-513f195c4afe"),
Guid.Parse("019e1b45-9084-76c2-8e5a-327dbc7ad852"),
Guid.Parse("019e1b45-9084-77d6-befa-9ebab50b3bd9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7e02-8998-b26c5b7dc76d"),
Guid.Parse("019e1b45-9084-7674-bfa8-ee455ccb88bf"),
Guid.Parse("019e1b45-9084-7401-84ea-df7357fe1cad"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7592-901f-0566c2e392c4"),
Guid.Parse("019e1b45-9084-7fce-956f-6a711f2c76f2"),
Guid.Parse("019e1b45-9084-70d1-9a1e-bbf42951ec29"),
Guid.Parse("019e1b45-9084-7c68-ac06-671458e522a3"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 107,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-77c1-b1f8-c67f53d380d8"),
Guid.Parse("019e1b45-9084-7c5d-a498-a4e34141c1de"),
Guid.Parse("019e1b45-9084-753d-b97c-1594c5aa0694"),
Guid.Parse("019e1b45-9084-7897-bed8-1927a65f2fb6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7ab3-bc39-1180b54f040b"),
Guid.Parse("019e1b45-9084-7525-9e8f-c536ae7c3f27"),
Guid.Parse("019e1b45-9084-7842-b631-0e2e0b5ab441"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7512-a3b9-55379aac3d8a"),
Guid.Parse("019e1b45-9084-7f30-ad68-92689ee8d0f1"),
Guid.Parse("019e1b45-9084-7e8d-a963-f7c924d12f36"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7730-97ff-20db9afa46f7"),
Guid.Parse("019e1b45-9084-773e-82d6-fba4e1547d4d"),
Guid.Parse("019e1b45-9084-7a1f-a273-ea55bfa00b79"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7528-aa98-07512ac2c16b"),
Guid.Parse("019e1b45-9084-715c-b383-a29768def0b8"),
Guid.Parse("019e1b45-9084-74dc-81ba-a3a3db52c098"),
Guid.Parse("019e1b45-9084-776d-b11e-675903bd9ba5"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7a82-afec-1016c00c1613"),
Guid.Parse("019e1b45-9084-7538-8364-fd65a0032256"),
Guid.Parse("019e1b45-9084-75d7-b1be-8a4f1e9b35bb"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7d26-af58-c231edef3b49"),
Guid.Parse("019e1b45-9084-72ec-8355-4f3495d5a0f2"),
Guid.Parse("019e1b45-9084-78a8-ba37-59eeb9925f99"),
Guid.Parse("019e1b45-9084-7419-a304-dcb412e055cb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-739b-8b85-17293e3679ba"),
Guid.Parse("019e1b45-9084-7987-863b-bfed3c85abf9"),
Guid.Parse("019e1b45-9084-7ea5-8fca-5d97c3983c7c"),
Guid.Parse("019e1b45-9084-7751-a3a0-ec5a6cee804e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-77c7-a868-2c9f6e9c3c62"),
Guid.Parse("019e1b45-9084-70ef-999d-1ce95e30d8d7"),
Guid.Parse("019e1b45-9084-70bf-9787-e611bc60a018"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-78c8-ab1f-8ca2eb529be3"),
Guid.Parse("019e1b45-9084-788f-af7b-f560b561378b"),
Guid.Parse("019e1b45-9084-7626-b5e7-1944a20ace14"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-717f-b02b-c5240e46af03"),
Guid.Parse("019e1b45-9084-794d-b5d0-7c5c5f5c9213"),
Guid.Parse("019e1b45-9084-7710-9303-1434bb5fc9cb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7f16-bc35-8bd2c57a9e1f"),
Guid.Parse("019e1b45-9084-75bb-9e40-4022bcf33edd"),
Guid.Parse("019e1b45-9084-72ae-a92d-bde14c2f5713"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7cd6-bc75-38935d58187c"),
Guid.Parse("019e1b45-9084-70ac-b6e7-c61c25ca0b64"),
Guid.Parse("019e1b45-9084-7fb3-bd46-f99a9f522c7c"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7369-ae4e-2ed885f6809f"),
Guid.Parse("019e1b45-9084-7916-934d-7940295c0ea2"),
Guid.Parse("019e1b45-9084-76f4-891e-bd30892404f1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7fa1-ac4b-79ac6007b0fa"),
Guid.Parse("019e1b45-9084-7d3d-9302-fa9ddbbd181d"),
Guid.Parse("019e1b45-9084-788a-a31c-51caf05e8a58"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-76d2-b091-8a75e23016e4"),
Guid.Parse("019e1b45-9084-774b-8541-ab8f3cff5caa"),
Guid.Parse("019e1b45-9084-7461-ade3-3ca74eef1162"),
Guid.Parse("019e1b45-9084-7ab8-969d-73b5bcdf604e"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-751d-a5f9-093f0e555975"),
Guid.Parse("019e1b45-9084-7e30-b4f5-5d56ac64c960"),
Guid.Parse("019e1b45-9084-7dd5-98c2-23815799a086"),
Guid.Parse("019e1b45-9084-79d7-9f3e-1d8c600f1027"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7a41-9521-1630958fe334"),
Guid.Parse("019e1b45-9084-724e-9a27-15e50a1722bf"),
Guid.Parse("019e1b45-9084-7b08-9e88-ffe911d8f45c"),
Guid.Parse("019e1b45-9084-7c0f-8e21-53b23b857364"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7b97-9877-1f6e77a20612"),
Guid.Parse("019e1b45-9084-7e6f-a9fb-5e0745e681a9"),
Guid.Parse("019e1b45-9084-7a65-8e0b-950e7ca7c7ac"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7ef1-ad0f-6447187e4891"),
Guid.Parse("019e1b45-9084-7509-abed-4e03c2c30fd1"),
Guid.Parse("019e1b45-9084-74df-830b-00ebe5de43ff"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7731-8ead-61b6e0886864"),
Guid.Parse("019e1b45-9084-7d06-9302-5f447ab74287"),
Guid.Parse("019e1b45-9084-72d8-a49c-52d2cc81691d"),
Guid.Parse("019e1b45-9084-7d75-8296-f0ddb6c22d56"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7f08-8f90-178896334018"),
Guid.Parse("019e1b45-9084-7fa2-98ef-ec23f5a65cf9"),
Guid.Parse("019e1b45-9084-7ecd-b90f-a6fa250654e5"),
Guid.Parse("019e1b45-9084-7528-9f57-00cb1f09640a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7998-8b9d-af77609129c2"),
Guid.Parse("019e1b45-9084-7a51-bf80-393a8efd42f8"),
Guid.Parse("019e1b45-9084-760c-ba40-1be9c4cfc1b8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7241-95dc-3014b327cfc0"),
Guid.Parse("019e1b45-9084-7790-886c-911a74d7d8bc"),
Guid.Parse("019e1b45-9084-78d7-853f-37407860494f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7676-a56f-7961609df5f0"),
Guid.Parse("019e1b45-9084-702d-ab87-9e15fb965508"),
Guid.Parse("019e1b45-9084-7a39-b9d8-9e4981cf3f2c"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 157,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7141-8fa8-1e4c8671e7cc"),
Guid.Parse("019e1b45-9084-73d2-9130-c9b5871ce9f6"),
Guid.Parse("019e1b45-9084-78d0-a31d-8dc14293afab"),
Guid.Parse("019e1b45-9084-7aaf-961f-404bc19588bc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 132,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7f15-bd5e-0fac3f673b32"),
Guid.Parse("019e1b45-9084-7be7-9219-dc10d893fd2c"),
Guid.Parse("019e1b45-9084-7a6c-8e65-234dfd3cd64b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7b8a-8884-495f0bb26e60"),
Guid.Parse("019e1b45-9084-7575-a0ce-20ad7f9f8574"),
Guid.Parse("019e1b45-9084-7f2e-b0ca-06b7b6752354"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-73e9-b9b1-c793313cf8ed"),
Guid.Parse("019e1b45-9084-775e-8a76-4a3314404eba"),
Guid.Parse("019e1b45-9084-74ca-9e1c-9aba7bb4e47b"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-715a-96ac-81c02bb6e819"),
Guid.Parse("019e1b45-9084-7380-a5a7-525bd4a6e875"),
Guid.Parse("019e1b45-9084-7570-9a48-f86dc93379c9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7f2e-9494-68b6d8417530"),
Guid.Parse("019e1b45-9084-7a74-a7c9-5e6fa0981ad2"),
Guid.Parse("019e1b45-9084-7499-ab5e-8d7ce424ebd9"),
Guid.Parse("019e1b45-9084-7c44-8523-a82a7c271d2f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7283-89b4-dbf496f6cf2e"),
Guid.Parse("019e1b45-9084-7524-b8f9-b57d1ca23e7f"),
Guid.Parse("019e1b45-9084-7dfb-a0fa-fade04ad0984"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 169,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-72dc-a8b9-b13c4d92a8cc"),
Guid.Parse("019e1b45-9084-76fc-890e-cf6f60a518d9"),
Guid.Parse("019e1b45-9084-7539-9180-9f30ab8c184d"),
Guid.Parse("019e1b45-9084-73b4-a36a-9f3183f58d0c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7104-8c86-15356f0da19e"),
Guid.Parse("019e1b45-9084-784d-aba0-afa5ca291303"),
Guid.Parse("019e1b45-9084-75d5-81cc-4fb014e658cc"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-78fd-9e5e-eb1358ef0bc5"),
Guid.Parse("019e1b45-9084-7627-8184-e4885680d498"),
Guid.Parse("019e1b45-9084-7907-bae2-38cdb0afeb7c"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-78bd-acc1-2fcb440df09e"),
Guid.Parse("019e1b45-9084-7772-972c-3e30760febb8"),
Guid.Parse("019e1b45-9084-747a-8d04-df5c73c11b70"),
Guid.Parse("019e1b45-9084-7809-b440-67ff340d0796"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7085-b1d6-072e3ce89cc4"),
Guid.Parse("019e1b45-9084-7125-87f1-625a9930a230"),
Guid.Parse("019e1b45-9084-7a59-9321-57e1d9b853ab"),
Guid.Parse("019e1b45-9084-76b9-b1eb-f6d437c813a2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 183,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-716a-a7c2-ef6c5cd80afd"),
Guid.Parse("019e1b45-9084-79fc-b691-05bfc214f0c3"),
Guid.Parse("019e1b45-9084-7b63-8d11-bb1888da34fa"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-71a5-9ca2-97739c16a161"),
Guid.Parse("019e1b45-9084-78bf-8f3f-78c73c7352d5"),
Guid.Parse("019e1b45-9084-7596-af27-a35cd5ede6da"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-72eb-a044-0e7831fcc688"),
Guid.Parse("019e1b45-9084-7d65-9d94-1b0fec5f9468"),
Guid.Parse("019e1b45-9084-7a44-aca6-32602b88e2b8"),
Guid.Parse("019e1b45-9084-7567-a352-dd0084ca7c8e"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 184,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7a86-b592-46e771ca90ba"),
Guid.Parse("019e1b45-9084-7e50-8807-0d706b9c25ad"),
Guid.Parse("019e1b45-9084-77c3-85dc-485ec0c16d28"),
Guid.Parse("019e1b45-9084-7d3b-a4b2-4d8f3303ba3f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-79e0-977c-343a4ec35ec8"),
Guid.Parse("019e1b45-9084-75aa-b7ca-a8e9c1a0457a"),
Guid.Parse("019e1b45-9084-7a27-891b-b0dd6c8fb4c8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7ebf-9dd3-eab88e26262b"),
Guid.Parse("019e1b45-9084-7378-b460-bd3804b95e78"),
Guid.Parse("019e1b45-9084-7b04-afd1-1e6b226ed08b"),
Guid.Parse("019e1b45-9084-7ae3-8640-82a34af044e0"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 189,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7bba-a638-8db05c146679"),
Guid.Parse("019e1b45-9084-7817-9162-98623cc22c80"),
Guid.Parse("019e1b45-9084-7120-9f84-7c866a664344"),
Guid.Parse("019e1b45-9084-72a2-9f22-4dc5ed336b0f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-72ff-830f-01096865aec5"),
Guid.Parse("019e1b45-9084-744a-b3f1-8d7e2d9fab0d"),
Guid.Parse("019e1b45-9084-7d8e-ab0a-dff680bff7a6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7521-be97-5552293d54c2"),
Guid.Parse("019e1b45-9084-7e12-8201-2dcf2e6091df"),
Guid.Parse("019e1b45-9084-7c91-b495-9be780b68086"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 197,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-72a0-adff-c38fc23298fb"),
Guid.Parse("019e1b45-9084-78c0-a07c-41d3c726004f"),
Guid.Parse("019e1b45-9084-7587-8668-c09ba24ece2f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-704e-9473-7ac984ddbc94"),
Guid.Parse("019e1b45-9084-7985-bba2-9061a3a082d7"),
Guid.Parse("019e1b45-9084-74cb-a2a2-96ae9033cfc6"),
Guid.Parse("019e1b45-9084-7679-9d51-0fd6adf30a4c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-73c8-9bfa-27e9742be57e"),
Guid.Parse("019e1b45-9084-76e3-a2a2-9b90a4a4a0a1"),
Guid.Parse("019e1b45-9084-754b-bac4-794eee74c846"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 202,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-795e-ac97-7b27826abc37"),
Guid.Parse("019e1b45-9084-73f4-95a9-3448f4c22123"),
Guid.Parse("019e1b45-9084-7be6-aa43-a165edddf16e"),
Guid.Parse("019e1b45-9084-71b4-a02d-3d1200182949"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7f88-9e59-9965a427e279"),
Guid.Parse("019e1b45-9084-75f3-adac-f2a3bf7060c0"),
Guid.Parse("019e1b45-9084-79e7-83b7-e940041af03a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-776d-8332-1a4ea54e5f8e"),
Guid.Parse("019e1b45-9084-76f5-8d71-4ffc7ce46727"),
Guid.Parse("019e1b45-9084-7cd6-8fd5-b2558fea4a94"),
Guid.Parse("019e1b45-9084-7565-96e6-909eaa5e0a21"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 209,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7c72-8015-75a2fc29dbcf"),
Guid.Parse("019e1b45-9084-7d17-9718-f96c7b8e34ba"),
Guid.Parse("019e1b45-9084-71e6-8874-bd609d4cc2d0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7f8f-83dc-bac882952de3"),
Guid.Parse("019e1b45-9084-768e-97cf-86c63206cdc7"),
Guid.Parse("019e1b45-9084-7581-b496-3862ff66f431"),
Guid.Parse("019e1b45-9084-737a-b2dd-80e47673c54e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-9084-7a87-8532-bffa8cf28fd7"),
Guid.Parse("019e1b45-9084-735e-8502-8bd65a19d7f4"),
Guid.Parse("019e1b45-9084-710b-8861-a9c2d3b98926"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-9084-7f81-b9dc-16b3f4f2ac23"),
Guid.Parse("019e1b45-9084-7d1a-af35-3ce0e7c790c5"),
Guid.Parse("019e1b45-9084-74d9-a923-a4e5b9b88d30"),
Guid.Parse("019e1b45-9084-7be5-99f4-9b0a40e74b22"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidv7marrayd1e1m(
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
FROM gedaqtests.guidv7marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7MArrayD1E1M)],
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
                    Guidv7MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    Guidv7MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

