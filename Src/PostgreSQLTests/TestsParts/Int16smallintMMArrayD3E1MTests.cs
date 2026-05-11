

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
    internal partial interface IInt16MArraysmallintMMArrayD3
    {
    }
    
    internal partial class Int16MArraysmallintMMArrayD3 : IInt16MArraysmallintMMArrayD3
    {


#region TestData

        private readonly Int16smallintMMArrayD3E1M[] _testData = new Int16smallintMMArrayD3E1M[]
        {
            new Int16smallintMMArrayD3E1M
{
    Id = 4,
    Value = 
new System.Int16[,,] { { { 20328, 11617, 31933, }, { 8061, 13515, 20426, }, { 6734, 8187, 17830, }, }, { { 32253, 8430, 27053, }, { 2133, 26033, 6260, }, { 7631, 12543, 4368, }, }, { { 28602, 25572, 26114, }, { 20239, 27552, 15032, }, { 21234, 9563, 12107, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 11,
    Value = 
new System.Int16[,,] { { { 16333, 13474, 17144, }, { 4979, 29392, 29494, }, { 10807, 29408, 1906, }, }, { { 30662, 1142, 30879, }, { 18295, 12637, 20960, }, { 23574, 10056, 29955, }, }, { { 4725, 28120, 25945, }, { 29940, 10363, 24341, }, { 30941, 2524, 21861, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 2,
    Value = 
new System.Int16[,,] { { { 8713, 23624, 17646, }, { 24570, 32126, 18039, }, { 23407, 10201, 17253, }, }, { { 11836, 13642, 32229, }, { 11099, 31538, 13168, }, { 28326, 26352, 10274, }, }, { { 6328, 16562, 22560, }, { 6353, 29810, 20516, }, { 31940, 2015, 32046, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 11461, 49, 3418, }, { 2616, 10277, 21655, }, { 22182, 10220, 8053, }, }, { { 18725, 26039, 30866, }, { 5878, 2892, 19498, }, { 20969, 23769, 26398, }, }, { { 26505, 9901, 11389, }, { 4743, 13301, 9191, }, { 3272, 7209, 12341, }, }, },
},
    NullableValue = 
new System.Int16[,,] { { { 16018, 25211, 19846, }, { 19183, 31793, 5259, }, { 13208, 20599, 25147, }, }, { { 15097, 13077, 31657, }, { 6041, 30984, 5673, }, { 19455, 14225, 30536, }, }, { { 3203, 25165, 1772, }, { 25311, 17112, 6366, }, { 20608, 21405, 3295, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 19,
    Value = 
new System.Int16[,,] { { { 16751, 22241, 8330, }, { 5238, 10595, 29647, }, { 21787, 11060, 28229, }, }, { { 9995, 31704, 26332, }, { 21850, 22037, 29865, }, { 26109, 14175, 17690, }, }, { { 24047, 17226, 12814, }, { 12876, 8953, 5268, }, { 25201, 13058, 27493, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 1469, 9446, 20680, }, { 23879, 27522, 15953, }, { 29262, 31502, 27253, }, }, { { 28044, 7034, 28863, }, { 18825, 14833, 16640, }, { 28443, 3141, 32422, }, }, { { 32060, 639, 31900, }, { 20481, 27677, 23358, }, { 13851, 22594, 12596, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 27,
    Value = 
new System.Int16[,,] { { { 28745, 503, 10157, }, { 30127, 32114, 25711, }, { 1053, 20084, 1148, }, }, { { 12710, 17486, 24840, }, { 12237, 4584, 10752, }, { 32105, 22865, 16424, }, }, { { 12752, 22262, 19101, }, { 10379, 9133, 24036, }, { 19348, 15388, 1153, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 7,
    Value = 
new System.Int16[,,] { { { 24957, 7237, 27369, }, { 31514, 8110, 24923, }, { 20300, 4814, 32729, }, }, { { 18614, 25255, 19063, }, { 30702, 27146, 14870, }, { 30617, 21421, 7285, }, }, { { 1143, 631, 9955, }, { 2154, 10685, 2384, }, { 2843, 12710, 20857, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,,] { { { 18188, 2875, 11742, }, { 27200, 11091, 11821, }, { 16129, 5253, 4264, }, }, { { 8314, 18427, 27730, }, { 8397, 31301, 24239, }, { 17239, 27676, 29718, }, }, { { 19202, 986, 2556, }, { 21254, 24851, 28479, }, { 26700, 5388, 7607, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 34,
    Value = 
new System.Int16[,,] { { { 28592, 16917, 10612, }, { 7677, 7949, 24708, }, { 13998, 32056, 9398, }, }, { { 15000, 9268, 17024, }, { 29355, 4359, 24921, }, { 13217, 3873, 21330, }, }, { { 13492, 30004, 24761, }, { 20865, 10774, 8853, }, { 16291, 4610, 15425, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 17883, 24752, 7395, }, { 24782, 31301, 11712, }, { 9157, 19461, 10952, }, }, { { 27116, 6599, 23884, }, { 339, 2909, 11682, }, { 30033, 25269, 31750, }, }, { { 21659, 23989, 22925, }, { 11683, 10809, 2005, }, { 3976, 31245, 16839, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 43,
    Value = 
new System.Int16[,,] { { { 10243, 15118, 28371, }, { 24098, 29133, 1158, }, { 2990, 4803, 6118, }, }, { { 30252, 19244, 1466, }, { 18154, 12086, 15577, }, { 16677, 19431, 25531, }, }, { { 8444, 7748, 1347, }, { 22718, 24996, 11105, }, { 10873, 30026, 8527, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 14,
    Value = 
new System.Int16[,,] { { { 11439, 6190, 19201, }, { 30822, 30464, 25910, }, { 29890, 273, 1158, }, }, { { 4193, 11133, 29787, }, { 2116, 8734, 12879, }, { 7695, 12106, 15896, }, }, { { 6741, 18490, 11715, }, { 9486, 12456, 17220, }, { 26804, 23518, 26744, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 10257, 15814, 21521, }, { 30019, 25337, 7015, }, { 20542, 11044, 3424, }, }, { { 29728, 6848, 9940, }, { 25970, 16519, 8400, }, { 27124, 4331, 9030, }, }, { { 6435, 14577, 17808, }, { 3822, 10397, 9577, }, { 30717, 3890, 13427, }, }, },
},
    NullableValue = 
new System.Int16[,,] { { { 11304, 12643, 1473, }, { 26343, 9000, 18661, }, { 2544, 22535, 31316, }, }, { { 13039, 8844, 21900, }, { 16782, 13390, 30735, }, { 22109, 16911, 18161, }, }, { { 282, 20313, 9316, }, { 13046, 12268, 24240, }, { 1911, 1264, 17841, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 47,
    Value = 
new System.Int16[,,] { { { 17897, 19064, 28324, }, { 2876, 5649, 2723, }, { 2915, 16410, 3800, }, }, { { 10539, 25339, 2696, }, { 6850, 1374, 10412, }, { 9599, 14337, 13508, }, }, { { 26684, 20176, 17421, }, { 22073, 15661, 28653, }, { 10214, 30530, 23886, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 56,
    Value = 
new System.Int16[,,] { { { 9950, 16268, 21726, }, { 13743, 25479, 29495, }, { 4389, 12588, 17794, }, }, { { 17459, 20611, 18321, }, { 20033, 21948, 23618, }, { 15651, 12243, 16635, }, }, { { 30018, 13561, 22518, }, { 17395, 22462, 30338, }, { 23293, 25920, 3405, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 19,
    Value = 
new System.Int16[,,] { { { 29775, 1002, 14863, }, { 18168, 16239, 31782, }, { 12502, 24253, 20974, }, }, { { 7898, 5781, 683, }, { 1165, 20851, 16798, }, { 7139, 1700, 24827, }, }, { { 15904, 16649, 7731, }, { 26217, 3807, 3946, }, { 24770, 26131, 8184, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 7951, 1545, 20852, }, { 15143, 884, 31896, }, { 813, 31048, 3633, }, }, { { 2380, 22591, 26674, }, { 28758, 10831, 12857, }, { 20966, 18144, 3424, }, }, { { 31430, 25582, 17519, }, { 8457, 11196, 23193, }, { 22049, 30934, 17552, }, }, },
},
    NullableValue = 
new System.Int16[,,] { { { 4137, 24883, 21107, }, { 13213, 24487, 5096, }, { 4417, 27456, 1044, }, }, { { 11607, 13066, 4082, }, { 27359, 26520, 26251, }, { 245, 32727, 24508, }, }, { { 15811, 30768, 21401, }, { 32740, 22329, 10289, }, { 19268, 19578, 20010, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 59,
    Value = 
new System.Int16[,,] { { { 12091, 12975, 16499, }, { 17782, 2453, 30549, }, { 14352, 30138, 12512, }, }, { { 25742, 23450, 16518, }, { 30196, 21577, 11444, }, { 14582, 24349, 5848, }, }, { { 27271, 17142, 17191, }, { 3491, 4104, 32376, }, { 8389, 18184, 21709, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 66,
    Value = 
new System.Int16[,,] { { { 12351, 12387, 21142, }, { 6131, 6485, 27511, }, { 28474, 21933, 26513, }, }, { { 14429, 9188, 11164, }, { 15831, 29448, 18050, }, { 130, 3019, 13300, }, }, { { 7160, 13125, 12616, }, { 24412, 7613, 17015, }, { 19157, 14747, 17175, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 26,
    Value = 
new System.Int16[,,] { { { 19970, 12885, 17180, }, { 26962, 1100, 13336, }, { 24979, 8922, 414, }, }, { { 11572, 16786, 26335, }, { 22253, 6259, 16706, }, { 17771, 5232, 30435, }, }, { { 25712, 15386, 12666, }, { 4186, 29580, 21092, }, { 4336, 5249, 26256, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 69,
    Value = 
new System.Int16[,,] { { { 8721, 12960, 26574, }, { 23134, 8656, 22023, }, { 31712, 21077, 3942, }, }, { { 28867, 4408, 7376, }, { 23557, 29436, 8717, }, { 13469, 10704, 32548, }, }, { { 9995, 21887, 16188, }, { 22188, 14113, 32397, }, { 2238, 29821, 1877, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 72,
    Value = 
new System.Int16[,,] { { { 24978, 12497, 25066, }, { 9775, 20009, 874, }, { 12003, 4694, 11958, }, }, { { 13212, 25306, 7151, }, { 24956, 18668, 16645, }, { 19641, 9125, 3061, }, }, { { 4312, 31964, 7522, }, { 28643, 2206, 29927, }, { 25310, 8603, 12076, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 34,
    Value = 
new System.Int16[,,] { { { 6404, 27760, 16807, }, { 28912, 26866, 29711, }, { 22608, 25937, 28022, }, }, { { 21180, 4245, 21364, }, { 18102, 2901, 31703, }, { 2015, 3156, 32240, }, }, { { 7121, 29711, 20983, }, { 9403, 17452, 1135, }, { 21557, 7516, 31897, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,,] { { { 15529, 1952, 233, }, { 1510, 3488, 30492, }, { 11517, 23129, 18129, }, }, { { 14110, 7567, 30032, }, { 5213, 29729, 13776, }, { 13198, 30546, 2772, }, }, { { 9574, 24884, 25774, }, { 8908, 31443, 2687, }, { 2384, 22811, 27817, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 77,
    Value = 
new System.Int16[,,] { { { 28612, 16819, 25861, }, { 15664, 106, 12506, }, { 30294, 4404, 21694, }, }, { { 21176, 14880, 5940, }, { 23139, 11895, 20440, }, { 4657, 10322, 15812, }, }, { { 18105, 26367, 17206, }, { 15228, 15398, 7316, }, { 18393, 2790, 27760, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 78,
    Value = 
new System.Int16[,,] { { { 9141, 13949, 1787, }, { 13764, 9733, 14165, }, { 12077, 32529, 244, }, }, { { 5265, 13008, 883, }, { 26889, 25209, 3972, }, { 17039, 27898, 2057, }, }, { { 19320, 9738, 27210, }, { 12784, 17596, 9603, }, { 30134, 3178, 4668, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 37,
    Value = 
new System.Int16[,,] { { { 2554, 22082, 17380, }, { 12414, 21720, 29159, }, { 10126, 4162, 11397, }, }, { { 21107, 21181, 8111, }, { 26940, 6895, 12244, }, { 29448, 25738, 1958, }, }, { { 21523, 26242, 24967, }, { 1360, 10722, 19510, }, { 15598, 19012, 29505, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 4734, 2181, 12673, }, { 9840, 32711, 27511, }, { 16866, 6078, 12722, }, }, { { 26602, 18726, 11972, }, { 31508, 24979, 3431, }, { 4631, 23601, 8951, }, }, { { 30331, 12343, 2872, }, { 9276, 19574, 15792, }, { 18470, 11720, 22400, }, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 79,
    Value = 
new System.Int16[,,] { { { 13707, 28361, 15163, }, { 9888, 13524, 4254, }, { 12382, 4090, 32503, }, }, { { 24357, 6321, 9647, }, { 17397, 26573, 28629, }, { 32388, 18832, 2960, }, }, { { 22362, 29190, 19817, }, { 21376, 16329, 2555, }, { 5581, 4104, 8175, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 83,
    Value = 
new System.Int16[,,] { { { 4997, 6512, 22439, }, { 7033, 13093, 13932, }, { 9671, 23988, 27710, }, }, { { 23950, 25866, 9137, }, { 17132, 22340, 17026, }, { 18700, 10436, 11366, }, }, { { 22374, 18317, 15563, }, { 17559, 8683, 18086, }, { 32432, 14573, 25325, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 41,
    Value = 
new System.Int16[,,] { { { 30553, 27821, 25039, }, { 25994, 20819, 14561, }, { 32239, 11820, 26656, }, }, { { 12144, 20407, 9015, }, { 29743, 16671, 23214, }, { 266, 18429, 23843, }, }, { { 22715, 11206, 14693, }, { 202, 11825, 16187, }, { 26773, 3106, 5525, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 17247, 24641, 9200, }, { 4459, 3323, 8645, }, { 6768, 19168, 30697, }, }, { { 12314, 28583, 7539, }, { 21212, 17718, 5797, }, { 19147, 5218, 8846, }, }, { { 17110, 4280, 1093, }, { 24362, 28343, 31790, }, { 29641, 20324, 24095, }, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 92,
    Value = 
new System.Int16[,,] { { { 26489, 27022, 7460, }, { 4861, 22837, 25084, }, { 16302, 6670, 8324, }, }, { { 25343, 30046, 4167, }, { 26590, 1541, 12043, }, { 5832, 32136, 14780, }, }, { { 21415, 3482, 2138, }, { 27552, 32603, 13761, }, { 20597, 28322, 1957, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 23179, 13657, 29235, }, { 13737, 10335, 19832, }, { 774, 2382, 9051, }, }, { { 28907, 20798, 13326, }, { 9965, 24669, 19013, }, { 31569, 29118, 29393, }, }, { { 32532, 7412, 24738, }, { 19083, 2967, 22605, }, { 25532, 12406, 27049, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 99,
    Value = 
new System.Int16[,,] { { { 12670, 28528, 20429, }, { 6130, 28484, 30216, }, { 27230, 2117, 11381, }, }, { { 4536, 9871, 18617, }, { 6365, 10559, 31574, }, { 16044, 21505, 28988, }, }, { { 13452, 4963, 32658, }, { 10607, 2296, 18505, }, { 3421, 26937, 29638, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 43,
    Value = 
new System.Int16[,,] { { { 31672, 17157, 2073, }, { 20636, 24278, 15186, }, { 18912, 14708, 9061, }, }, { { 6090, 20255, 12507, }, { 20634, 29847, 25053, }, { 7040, 8693, 17851, }, }, { { 23453, 24936, 25157, }, { 31597, 2817, 10563, }, { 3872, 19567, 31323, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 106,
    Value = 
new System.Int16[,,] { { { 984, 396, 6866, }, { 13519, 3847, 6821, }, { 9343, 27140, 1461, }, }, { { 13967, 609, 27490, }, { 26022, 2968, 4971, }, { 29110, 5898, 20529, }, }, { { 28072, 11308, 31932, }, { 20328, 31719, 14076, }, { 21700, 26463, 32466, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 19748, 2956, 1916, }, { 8573, 20665, 16738, }, { 28972, 28447, 28094, }, }, { { 9429, 32228, 5344, }, { 31055, 3523, 20690, }, { 28757, 22147, 27899, }, }, { { 15433, 15926, 24358, }, { 18465, 564, 4087, }, { 16435, 8950, 16690, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 112,
    Value = 
new System.Int16[,,] { { { 6120, 31120, 18472, }, { 11479, 14412, 23588, }, { 13905, 31961, 11044, }, }, { { 7179, 11765, 23596, }, { 29436, 1968, 6504, }, { 646, 2285, 26640, }, }, { { 9924, 31950, 16599, }, { 4423, 13687, 23330, }, { 25145, 768, 10632, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 51,
    Value = 
new System.Int16[,,] { { { 25647, 14707, 22438, }, { 8324, 10453, 10598, }, { 12628, 24743, 21396, }, }, { { 16993, 28500, 30891, }, { 10242, 11854, 21526, }, { 649, 4654, 22727, }, }, { { 7467, 15812, 26848, }, { 27722, 1001, 28699, }, { 1653, 24859, 6170, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 23255, 15325, 31928, }, { 29311, 18238, 15348, }, { 17860, 9812, 20654, }, }, { { 20067, 1377, 6153, }, { 22744, 24518, 5798, }, { 31170, 19389, 25310, }, }, { { 5334, 16935, 1836, }, { 28201, 26384, 25648, }, { 28681, 26696, 19975, }, }, },
},
    NullableValue = 
new System.Int16[,,] { { { 15156, 30811, 15581, }, { 27012, 12620, 224, }, { 20321, 19488, 318, }, }, { { 30594, 27546, 29902, }, { 18222, 30310, 11454, }, { 27884, 11549, 6194, }, }, { { 29535, 29720, 8855, }, { 27016, 29898, 7897, }, { 21553, 8460, 4360, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 116,
    Value = 
new System.Int16[,,] { { { 3518, 23577, 30623, }, { 24586, 21955, 8290, }, { 25483, 16941, 32764, }, }, { { 17386, 26117, 16080, }, { 4427, 22813, 3750, }, { 25439, 1313, 25277, }, }, { { 30114, 3394, 30378, }, { 2559, 1034, 8170, }, { 31954, 13711, 4635, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 15287, 7535, 4563, }, { 25918, 26863, 21541, }, { 22058, 2864, 16435, }, }, { { 15836, 23913, 22293, }, { 6674, 27989, 23778, }, { 6451, 15995, 15555, }, }, { { 6185, 4193, 15294, }, { 8603, 18290, 12746, }, { 7200, 7406, 7011, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 117,
    Value = 
new System.Int16[,,] { { { 17510, 5973, 8900, }, { 992, 9196, 18801, }, { 24825, 13462, 12155, }, }, { { 10145, 31201, 8666, }, { 19173, 30183, 22543, }, { 8508, 3179, 14147, }, }, { { 25936, 12459, 11529, }, { 8621, 9357, 3483, }, { 15157, 8357, 10372, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 55,
    Value = 
new System.Int16[,,] { { { 13596, 18059, 14393, }, { 1567, 17106, 25291, }, { 14362, 20358, 22454, }, }, { { 2476, 30665, 7565, }, { 4621, 6328, 10383, }, { 545, 3274, 13100, }, }, { { 11924, 4219, 8121, }, { 11360, 1779, 10968, }, { 31039, 31618, 14871, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 27081, 29162, 13590, }, { 18118, 28093, 20019, }, { 28440, 26266, 6117, }, }, { { 23404, 13983, 6746, }, { 32361, 11127, 13853, }, { 14625, 17717, 19735, }, }, { { 10237, 8267, 14809, }, { 7147, 16530, 23568, }, { 17718, 13464, 22671, }, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 119,
    Value = 
new System.Int16[,,] { { { 29244, 1647, 11978, }, { 28701, 31686, 30305, }, { 25887, 12253, 8903, }, }, { { 32089, 5324, 23976, }, { 17517, 27567, 24508, }, { 4661, 31594, 4843, }, }, { { 13478, 1016, 17960, }, { 10626, 6408, 18397, }, { 26962, 8665, 32701, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 128,
    Value = 
new System.Int16[,,] { { { 28897, 25160, 28411, }, { 17230, 11745, 22923, }, { 12610, 13546, 4022, }, }, { { 9848, 17302, 10454, }, { 11945, 28087, 13321, }, { 16320, 11376, 721, }, }, { { 23071, 21457, 9981, }, { 17777, 3005, 26694, }, { 28788, 16612, 23794, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 61,
    Value = 
new System.Int16[,,] { { { 11261, 26836, 29954, }, { 13557, 24178, 3798, }, { 7767, 23873, 27616, }, }, { { 22670, 13609, 21088, }, { 5815, 12294, 8145, }, { 14770, 28817, 23450, }, }, { { 13820, 20380, 10724, }, { 4040, 8292, 5377, }, { 1337, 17545, 8337, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,,] { { { 22251, 11778, 22708, }, { 30331, 13427, 19787, }, { 11076, 28007, 3965, }, }, { { 3573, 27479, 18073, }, { 7311, 16348, 28553, }, { 24271, 21871, 15682, }, }, { { 25627, 23741, 13119, }, { 1042, 7093, 25277, }, { 13349, 405, 12162, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 134,
    Value = 
new System.Int16[,,] { { { 657, 187, 19119, }, { 17763, 26457, 15949, }, { 29324, 9323, 21181, }, }, { { 3381, 25253, 7921, }, { 5903, 1344, 20427, }, { 13947, 10709, 12113, }, }, { { 28599, 18999, 24466, }, { 24283, 24672, 28529, }, { 13814, 10501, 6153, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 6579, 19945, 20230, }, { 18734, 8303, 31969, }, { 4171, 25345, 8110, }, }, { { 5967, 6317, 21737, }, { 22311, 6012, 14849, }, { 4295, 8693, 10494, }, }, { { 252, 2747, 11663, }, { 32010, 16859, 1681, }, { 18017, 5728, 22528, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 142,
    Value = 
new System.Int16[,,] { { { 8684, 13560, 24566, }, { 6957, 12671, 10464, }, { 28950, 9103, 4747, }, }, { { 17261, 3549, 12719, }, { 20137, 11974, 3101, }, { 607, 21904, 807, }, }, { { 5796, 2775, 11490, }, { 13159, 27780, 29408, }, { 19219, 798, 30591, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 63,
    Value = 
new System.Int16[,,] { { { 1560, 15942, 14111, }, { 31803, 1319, 811, }, { 19851, 12187, 56, }, }, { { 5975, 17520, 19094, }, { 13871, 23145, 6302, }, { 3134, 21970, 6367, }, }, { { 30603, 31291, 8957, }, { 29862, 12902, 31525, }, { 8511, 17911, 18007, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 148,
    Value = 
new System.Int16[,,] { { { 29420, 9331, 8834, }, { 9731, 9454, 11036, }, { 31846, 8529, 27843, }, }, { { 31800, 23913, 8818, }, { 29835, 16843, 24810, }, { 18093, 8618, 14073, }, }, { { 3108, 16393, 2630, }, { 19915, 10807, 31791, }, { 27182, 30275, 11119, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 157,
    Value = 
new System.Int16[,,] { { { 28553, 20162, 5236, }, { 32667, 4768, 11559, }, { 17505, 1433, 5802, }, }, { { 20418, 25514, 24087, }, { 12253, 16623, 22697, }, { 19490, 17433, 17847, }, }, { { 23239, 18361, 19794, }, { 1852, 6593, 20399, }, { 15320, 9126, 16195, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 68,
    Value = 
new System.Int16[,,] { { { 7097, 8167, 29256, }, { 6273, 1697, 8848, }, { 20501, 7398, 6338, }, }, { { 16413, 18670, 28333, }, { 7225, 1313, 5760, }, { 10911, 7481, 3984, }, }, { { 12098, 2072, 17373, }, { 9467, 29975, 27825, }, { 1805, 27649, 29875, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,,] { { { 29161, 6739, 3227, }, { 4119, 14416, 8675, }, { 24727, 26747, 7683, }, }, { { 29807, 6013, 30767, }, { 23435, 27853, 20717, }, { 12130, 26026, 22747, }, }, { { 4962, 1690, 16455, }, { 4956, 9550, 23340, }, { 32643, 29162, 5743, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 166,
    Value = 
new System.Int16[,,] { { { 25083, 9248, 8745, }, { 4715, 6921, 11354, }, { 23221, 8098, 15297, }, }, { { 12886, 16640, 19953, }, { 4528, 2159, 27592, }, { 14414, 10249, 14393, }, }, { { 10999, 13436, 27681, }, { 16727, 20032, 1095, }, { 30863, 32557, 10791, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 174,
    Value = 
new System.Int16[,,] { { { 13097, 21684, 9041, }, { 15093, 6554, 27654, }, { 23144, 28022, 23268, }, }, { { 25382, 22520, 9522, }, { 23462, 21605, 15842, }, { 3563, 21068, 17821, }, }, { { 20272, 20668, 16795, }, { 11786, 11541, 30763, }, { 1518, 28399, 12844, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 77,
    Value = 
new System.Int16[,,] { { { 22239, 14966, 13130, }, { 13566, 21494, 20361, }, { 19134, 9267, 27913, }, }, { { 3665, 141, 21213, }, { 32219, 5783, 10800, }, { 23592, 18200, 8880, }, }, { { 24627, 25881, 625, }, { 804, 6405, 19105, }, { 10718, 2836, 21912, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 17699, 14197, 20880, }, { 29725, 6628, 9952, }, { 30418, 27617, 17888, }, }, { { 7619, 3238, 16837, }, { 25659, 6308, 23995, }, { 32368, 2054, 19365, }, }, { { 6953, 15056, 8517, }, { 21803, 12867, 2124, }, { 22734, 18702, 23474, }, }, },
},
    NullableValue = 
new System.Int16[,,] { { { 13703, 2722, 7462, }, { 22382, 2187, 3267, }, { 12136, 24939, 5447, }, }, { { 417, 8117, 22884, }, { 31526, 9300, 5140, }, { 18571, 7395, 4529, }, }, { { 8220, 24, 13498, }, { 11388, 22070, 15212, }, { 13263, 5059, 13914, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 175,
    Value = 
new System.Int16[,,] { { { 30060, 4128, 24072, }, { 27429, 29631, 27440, }, { 9788, 16155, 988, }, }, { { 12682, 7439, 15174, }, { 17431, 13790, 7320, }, { 8232, 15430, 5487, }, }, { { 30857, 14647, 2472, }, { 26051, 5552, 20626, }, { 17918, 26377, 25319, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 176,
    Value = 
new System.Int16[,,] { { { 20001, 12651, 8542, }, { 2533, 9020, 19594, }, { 1102, 28598, 9683, }, }, { { 3795, 288, 5981, }, { 14946, 3792, 21473, }, { 13645, 3042, 11366, }, }, { { 17254, 16041, 16215, }, { 7562, 7868, 25628, }, { 6189, 21126, 9345, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 78,
    Value = 
new System.Int16[,,] { { { 24454, 18203, 3342, }, { 31746, 8818, 10668, }, { 22583, 1767, 30385, }, }, { { 19079, 25921, 8370, }, { 30865, 9593, 29799, }, { 19172, 25129, 16268, }, }, { { 921, 20662, 10054, }, { 14927, 15230, 21869, }, { 30677, 8076, 17319, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,,] { { { 8911, 28062, 29113, }, { 21527, 20525, 31885, }, { 29477, 26478, 3446, }, }, { { 18202, 18885, 22574, }, { 18781, 24381, 19072, }, { 13592, 7618, 12422, }, }, { { 4648, 31028, 14076, }, { 18753, 20678, 19422, }, { 9858, 19869, 8984, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 183,
    Value = 
new System.Int16[,,] { { { 12541, 330, 18289, }, { 12981, 29699, 435, }, { 5527, 17147, 26365, }, }, { { 13489, 3015, 9948, }, { 5972, 13974, 19350, }, { 27653, 31162, 3119, }, }, { { 14025, 28706, 31486, }, { 15849, 30363, 552, }, { 19587, 518, 14708, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,,] { { { 6619, 15579, 13502, }, { 16777, 28779, 29545, }, { 22528, 17914, 7304, }, }, { { 9198, 18829, 16664, }, { 2266, 11917, 10540, }, { 29686, 3224, 6242, }, }, { { 20883, 28247, 14543, }, { 2626, 24575, 8075, }, { 14740, 11518, 23892, }, }, },
},
            new Int16smallintMMArrayD3E1M
{
    Id = 185,
    Value = 
new System.Int16[,,] { { { 17889, 6791, 14090, }, { 21018, 20077, 10513, }, { 10236, 22504, 9899, }, }, { { 13633, 6776, 22609, }, { 17336, 5689, 17149, }, { 23294, 15522, 1068, }, }, { { 22239, 21032, 7410, }, { 25513, 32341, 25239, }, { 31123, 22946, 6127, }, }, },
    ModelInner = new Int16smallintMMArrayD3E1MI
{
    Id = 87,
    Value = 
new System.Int16[,,] { { { 11932, 6260, 18714, }, { 18260, 29973, 5045, }, { 3004, 29287, 755, }, }, { { 18292, 15053, 16157, }, { 27364, 13575, 27113, }, { 5413, 4673, 13062, }, }, { { 26911, 23752, 29116, }, { 14150, 3845, 28471, }, { 20454, 21375, 5206, }, }, },
    NullableValue = 
new System.Int16[,,] { { { 6787, 29610, 31866, }, { 32439, 22625, 18269, }, { 10129, 15949, 16141, }, }, { { 21334, 10417, 21800, }, { 16249, 10292, 29125, }, { 25787, 11177, 2871, }, }, { { 304, 2168, 5834, }, { 26054, 5921, 19690, }, { 13191, 27645, 7687, }, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD3E1M
{
    Id = 193,
    Value = 
new System.Int16[,,] { { { 17729, 20516, 14378, }, { 26336, 32346, 6776, }, { 8170, 28855, 28466, }, }, { { 17008, 10542, 12610, }, { 24812, 6949, 17936, }, { 4289, 8982, 29642, }, }, { { 12831, 10390, 16326, }, { 17768, 19147, 7742, }, { 12011, 20140, 9093, }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd3e1mi(
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd3e1mi(
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
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
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

                changedRows =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    int16smallintmmarrayd3e1mi_id
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintmmarrayd3e1mi_id", 
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
                changedRows =  ((IInt16MArraysmallintMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16MArraysmallintMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    int16smallintmmarrayd3e1mi_id
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
    int16smallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
                System.Int16[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,,]>();
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable =  ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,,] { { { 17883, 24752, 7395, }, { 24782, 31301, 11712, }, { 9157, 19461, 10952, }, }, { { 27116, 6599, 23884, }, { 339, 2909, 11682, }, { 30033, 25269, 31750, }, }, { { 21659, 23989, 22925, }, { 11683, 10809, 2005, }, { 3976, 31245, 16839, }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,,]>();
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable =  ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,,] { { { 11304, 12643, 1473, }, { 26343, 9000, 18661, }, { 2544, 22535, 31316, }, }, { { 13039, 8844, 21900, }, { 16782, 13390, 30735, }, { 22109, 16911, 18161, }, }, { { 282, 20313, 9316, }, { 13046, 12268, 24240, }, { 1911, 1264, 17841, }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,,]>();
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable = await ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,,]>();
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable = await ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,,] { { { 4137, 24883, 21107, }, { 13213, 24487, 5096, }, { 4417, 27456, 1044, }, }, { { 11607, 13066, 4082, }, { 27359, 26520, 26251, }, { 245, 32727, 24508, }, }, { { 15811, 30768, 21401, }, { 32740, 22329, 10289, }, { 19268, 19578, 20010, }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    int16smallintmmarrayd3e1mi_id
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
    int16smallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintmmarrayd3e1mi_id", 
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
                System.Int16[,,] nullable = null;
                nullable =  ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16[,,] nullable = null;
                nullable = await ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt16MArraysmallintMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,,] { { { 15529, 1952, 233, }, { 1510, 3488, 30492, }, { 11517, 23129, 18129, }, }, { { 14110, 7567, 30032, }, { 5213, 29729, 13776, }, { 13198, 30546, 2772, }, }, { { 9574, 24884, 25774, }, { 8908, 31443, 2687, }, { 2384, 22811, 27817, }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintMMArrayD3E1M> models = null;

                models =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintMMArrayD3E1M> models = null;

                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt16MArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M), typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                ((IInt16MArraysmallintMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt16MArraysmallintMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16MArraysmallintMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
LEFT JOIN public.int16smallintmmarrayd3e1mi mi ON mi.id = m.int16smallintmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
                var models = await ((IInt16MArraysmallintMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M), typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                ((IInt16MArraysmallintMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16MArraysmallintMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16MArraysmallintMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
LEFT JOIN public.int16smallintmmarrayd3e1mi mi ON mi.id = m.int16smallintmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
                var models = await ((IInt16MArraysmallintMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16MArraysmallintMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M), typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                ((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                 ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                 ((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 174;
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                 ((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
LEFT JOIN public.int16smallintmmarrayd3e1mi mi ON mi.id = m.int16smallintmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
                var models = await((IInt16MArraysmallintMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M), typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 174, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD3E1M>();
                ((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                 ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 175, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                 ((IInt16MArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 116, query1, 183, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 34, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 92, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
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
FROM public.int16smallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD3E1M>();
                 ((IInt16MArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt16smallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int16smallintmmarrayd3e1m m
LEFT JOIN public.int16smallintmmarrayd3e1mi mi ON mi.id = m.int16smallintmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
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
                var models = await((IInt16MArraysmallintMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 99, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[3], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[4], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[5], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[6], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[7], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[8], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[9], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[10], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[11], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[12], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[13], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[14], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[15], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[16], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[17], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[18], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[19], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[17],_testData[20], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[18],_testData[21], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[19],_testData[22], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[20],_testData[23], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[21],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[22],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[23],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[24],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[25],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[26],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[27],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[28],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[29],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[30],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 27, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((IInt16MArraysmallintMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16MArraysmallintMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((IInt16MArraysmallintMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16MArraysmallintMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16MArraysmallintMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 174);
                var models =  ((IInt16MArraysmallintMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                Int16smallintMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                Int16smallintMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_int16smallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD3E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16MArraysmallintMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16MArraysmallintMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16MArraysmallintMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16MArraysmallintMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16MArraysmallintMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16MArraysmallintMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16MArraysmallintMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16MArraysmallintMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD3E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16MArraysmallintMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16MArraysmallintMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16MArraysmallintMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt16MArraysmallintMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16MArraysmallintMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16MArraysmallintMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16MArraysmallintMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16MArraysmallintMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int16smallintMMArrayD3E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
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
FROM public.binary_int16smallintmmarrayd3e1m m
LEFT JOIN public.binary_int16smallintmmarrayd3e1mi mi ON mi.id = m.int16smallintmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt16MArraysmallintMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt16MArraysmallintMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt16MArraysmallintMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IInt16MArraysmallintMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models =  ((IInt16MArraysmallintMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16MArraysmallintMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA), typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models1 = new List<Int16smallintMMArrayD3E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD3E1MIWA>();
                await ((IInt16MArraysmallintMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD3E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD3E1MIWA>();
                ((IInt16MArraysmallintMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models = await ((IInt16MArraysmallintMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
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
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
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
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA), typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
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
                var models1 = new List<Int16smallintMMArrayD3E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD3E1MIWA>();
                await ((IInt16MArraysmallintMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD3E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD3E1MIWA>();
                ((IInt16MArraysmallintMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
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
                var models = await ((IInt16MArraysmallintMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
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
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int16smallintmmarrayd3e1mi
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
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MI), typeof(Int16smallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models1 = new List<Int16smallintMMArrayD3E1MI>();
                var models2 = new List<Int16smallintMMArrayD3E1MI>();
                await ((IInt16MArraysmallintMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD3E1MI>();
                var models2 = new List<Int16smallintMMArrayD3E1MI>();
                ((IInt16MArraysmallintMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models = await ((IInt16MArraysmallintMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA), typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
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
                var models1 = new List<Int16smallintMMArrayD3E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD3E1MIWA>();
                await ((IInt16MArraysmallintMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD3E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD3E1MIWA>();
                ((IInt16MArraysmallintMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD3))]
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
                var models = await ((IInt16MArraysmallintMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

