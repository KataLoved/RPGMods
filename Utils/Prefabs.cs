﻿namespace RPGMods.Utils; 

// Note that these prefabs are as of Gloomrot launch
// Thanks https://github.com/decaprime
public static class Prefabs {
    public enum Units {
        CHAR_ArchMage_FlameSphere = 2138173476,
        CHAR_ArchMage_Summon = 805231073,
        CHAR_ArchMage_VBlood = -2013903325,
        CHAR_Bandit_Bomber = -1128238456,
        CHAR_Bandit_Bomber_Servant = -450600397,
        CHAR_Bandit_Bomber_VBlood = 1896428751,
        CHAR_Bandit_Deadeye = -1030822544,
        CHAR_Bandit_Deadeye_Chaosarrow_VBlood = 763273073,
        CHAR_Bandit_Deadeye_Frostarrow_VBlood = 1124739990,
        CHAR_Bandit_Deadeye_Servant = -2086044081,
        CHAR_Bandit_Foreman_VBlood = 2122229952,
        CHAR_Bandit_GraveDigger_VBlood_UNUSED = 936169687,
        CHAR_Bandit_Hunter = -1301144178,
        CHAR_Bandit_Hunter_Servant = -370708253,
        CHAR_Bandit_Leader_VBlood_UNUSED = -175381832,
        CHAR_Bandit_Leader_Wolf_Summon = -671059374,
        CHAR_Bandit_Miner_Standard_Servant = 1112903312,
        CHAR_Bandit_Miner_VBlood_UNUSED = 276934707,
        CHAR_Bandit_Mugger = 2057508774,
        CHAR_Bandit_Mugger_Servant = 1727426580,
        CHAR_Bandit_Prisoner_Villager_Female = 1069072707,
        CHAR_Bandit_Prisoner_Villager_Male = 286320185,
        CHAR_Bandit_Stalker = -309264723,
        CHAR_Bandit_Stalker_Servant = 1453520986,
        CHAR_Bandit_Stalker_VBlood = 1106149033,
        CHAR_Bandit_StoneBreaker_VBlood = -2025101517,
        CHAR_Bandit_Thief = 923140362,
        CHAR_Bandit_Thief_Servant = -872078546,
        CHAR_Bandit_Thief_VBlood_UNUSED = 2139023341,
        CHAR_Bandit_Thug = -301730941,
        CHAR_Bandit_Thug_Servant = 1466015976,
        CHAR_Bandit_Tourok_VBlood = -1659822956,
        CHAR_Bandit_Trapper = -589412777,
        CHAR_Bandit_Trapper_Servant = 2112911542,
        CHAR_Bandit_Wolf = -1554428547,
        CHAR_Bandit_Woodcutter_Standard_Servant = 51737727,
        CHAR_Bandit_Worker_Gatherer = 1743532914,
        CHAR_Bandit_Worker_Gatherer_Servant = 48283616,
        CHAR_Bandit_Worker_Miner = -2039670689,
        CHAR_Bandit_Worker_Woodcutter = 1309418594,
        CHAR_BatVampire_VBlood = 1112948824,
        CHAR_ChurchOfLight_Archer = 426583055,
        CHAR_ChurchOfLight_Archer_Servant = -915884427,
        CHAR_ChurchOfLight_Cardinal_VBlood = 114912615,
        CHAR_ChurchOfLight_CardinalAide = 1745498602,
        CHAR_ChurchOfLight_Cleric = -1464869978,
        CHAR_ChurchOfLight_Cleric_Servant = 1218339832,
        CHAR_ChurchOfLight_EnchantedCross = -1449314709,
        CHAR_ChurchOfLight_Footman = 2128996433,
        CHAR_ChurchOfLight_Footman_Servant = -1719944550,
        CHAR_ChurchOfLight_Knight_2H = -930333806,
        CHAR_ChurchOfLight_Knight_2H_Servant = 17367048,
        CHAR_ChurchOfLight_Knight_Shield = 794228023,
        CHAR_ChurchOfLight_Knight_Shield_Servant = -694328454,
        CHAR_ChurchOfLight_Lightweaver = 1185952775,
        CHAR_ChurchOfLight_Lightweaver_Servant = -383158562,
        CHAR_ChurchOfLight_Miner_Standard = 924132254,
        CHAR_ChurchOfLight_Miner_Standard_Servant = -1988959460,
        CHAR_ChurchOfLight_Overseer_VBlood = -26105228,
        CHAR_ChurchOfLight_Paladin = 1728773109,
        CHAR_ChurchOfLight_Paladin_HomePos = -502558061,
        CHAR_ChurchOfLight_Paladin_Servant = 1649578802,
        CHAR_ChurchOfLight_Paladin_VBlood = -740796338,
        CHAR_ChurchOfLight_Priest = 1406393857,
        CHAR_ChurchOfLight_Priest_Servant = -1728284448,
        CHAR_ChurchOfLight_Rifleman = 1148936156,
        CHAR_ChurchOfLight_Rifleman_Servant = -268935837,
        CHAR_ChurchOfLight_SlaveMaster_Enforcer = 891705701,
        CHAR_ChurchOfLight_SlaveMaster_Enforcer_Servant = -2114140065,
        CHAR_ChurchOfLight_SlaveMaster_Sentry = -240536861,
        CHAR_ChurchOfLight_SlaveMaster_Sentry_Servant = -442412464,
        CHAR_ChurchOfLight_SlaveRuffian = -1875351031,
        CHAR_ChurchOfLight_SlaveRuffian_Cover = -1387838833,
        CHAR_ChurchOfLight_SlaveRuffian_Servant = -1416355128,
        CHAR_ChurchOfLight_SmiteOrb = 1917502536,
        CHAR_ChurchOfLight_Sommelier_BarrelMinion = -1917548708,
        CHAR_ChurchOfLight_Sommelier_VBlood = 192051202,
        CHAR_ChurchOfLight_Villager_Female = -1224027101,
        CHAR_ChurchOfLight_Villager_Female_Servant = 1157537604,
        CHAR_ChurchOfLight_Villager_Male = -2025921616,
        CHAR_ChurchOfLight_Villager_Male_Servant = -1786031969,
        CHAR_CopperGolem = 1107541186,
        CHAR_CreatureDeer_Mutated = -575831311,
        CHAR_CreatureMoose_Mutated = 1570140219,
        CHAR_Critter_Rat = -2072914343,
        CHAR_Critter_Silkworm = -1587402408,
        CHAR_Critter_VerminNest_Rat = -372256748,
        CHAR_Cultist_Pyromancer = 2055824593,
        CHAR_Cultist_Slicer = 1807491570,
        CHAR_Cursed_Bear_Spirit = 1105583702,
        CHAR_Cursed_Bear_Standard = -559819989,
        CHAR_Cursed_MonsterToad = 575918722,
        CHAR_Cursed_MonsterToad_Minion = -38041784,
        CHAR_Cursed_Mosquito = -744966291,
        CHAR_Cursed_MountainBeast_SpiritDouble = -935560085,
        CHAR_Cursed_MountainBeast_VBlood = -1936575244,
        CHAR_Cursed_Nightlurker = -2046268156,
        CHAR_Cursed_ToadKing_VBlood = -203043163,
        CHAR_Cursed_ToadSpitter = 1478790879,
        CHAR_Cursed_Witch = -56441915,
        CHAR_Cursed_Witch_Exploding_Mosquito = -1399273168,
        CHAR_Cursed_Witch_VBlood = -910296704,
        CHAR_Cursed_Wolf = -218175217,
        CHAR_Cursed_Wolf_Spirit = 407089231,
        CHAR_Cursed_WormTerror = 658578725,
        CHAR_Farmland_Wolf = -578677530,
        CHAR_Farmlands_Cow = 721166952,
        CHAR_Farmlands_Farmer = -1342764880,
        CHAR_Farmlands_Farmer_Servant = 516718373,
        CHAR_Farmlands_HostileVillager_Base = -2007601567,
        CHAR_Farmlands_HostileVillager_Female_FryingPan = 729746981,
        CHAR_Farmlands_HostileVillager_Female_Pitchfork = 1576267559,
        CHAR_Farmlands_HostileVillager_Male_Club = -164116132,
        CHAR_Farmlands_HostileVillager_Male_Shovel = -864975423,
        CHAR_Farmlands_HostileVillager_Male_Torch = -81727312,
        CHAR_Farmlands_HostileVillager_Male_Unarmed = -1353870145,
        CHAR_Farmlands_HostileVillager_Werewolf = -951976780,
        CHAR_Farmlands_Militia_Summon = -213868361,
        CHAR_Farmlands_Nun_Servant = -1788957652,
        CHAR_Farmlands_Pig = -1356006948,
        CHAR_Farmlands_Ram = 947731555,
        CHAR_Farmlands_Sheep = 1012307512,
        CHAR_Farmlands_SheepOld = 1635167941,
        CHAR_Farmlands_SmallPig = 1420480270,
        CHAR_Farmlands_Villager_Female = 525027204,
        CHAR_Farmlands_Villager_Female_Servant = 1532829342,
        CHAR_Farmlands_Villager_Female_Sister = 1772642154,
        CHAR_Farmlands_Villager_Female_Sister_Servant = -444945115,
        CHAR_Farmlands_Villager_Male = 1887807944,
        CHAR_Farmlands_Villager_Male_Servant = 1426964824,
        CHAR_Farmlands_Woodcutter_Standard = -893091615,
        CHAR_Farmlands_Woodcutter_Standard_Servant = -1659842473,
        CHAR_Forest_AngryMoose = 2097040330,
        CHAR_Forest_Bear_Dire_Vblood = -1391546313,
        CHAR_Forest_Bear_Standard = 1043643344,
        CHAR_Forest_Deer = 1897056612,
        CHAR_Forest_Moose = -831097925,
        CHAR_Forest_Wolf = -1418430647,
        CHAR_Forest_Wolf_VBlood = -1905691330,
        CHAR_Geomancer_Golem_Guardian = -2092246077,
        CHAR_Geomancer_Golem_VBlood = -1317534496,
        CHAR_Geomancer_Human_VBlood = -1065970933,
        CHAR_Gloomrot_AceIncinerator = 1756241788,
        CHAR_Gloomrot_AceIncinerator_Servant = -1897484769,
        CHAR_Gloomrot_Batoon = -1707267769,
        CHAR_Gloomrot_Batoon_Servant = 657708566,
        CHAR_Gloomrot_Iva_VBlood = 172235178,
        CHAR_Gloomrot_Monster_VBlood = 1233988687,
        CHAR_Gloomrot_Purifier_VBlood = 106480588,
        CHAR_Gloomrot_Pyro = -322293503,
        CHAR_Gloomrot_Pyro_Servant = 1304434816,
        CHAR_Gloomrot_Railgunner = 1732477970,
        CHAR_Gloomrot_Railgunner_Servant = -1070366200,
        CHAR_Gloomrot_RailgunSergeant_HomePos = -1499025256,
        CHAR_Gloomrot_RailgunSergeant_Minion = 1626314708,
        CHAR_Gloomrot_RailgunSergeant_VBlood = 2054432370,
        CHAR_Gloomrot_SentryOfficer = 1401026468,
        CHAR_Gloomrot_SentryOfficer_Servant = -1213645419,
        CHAR_Gloomrot_SentryTurret = -1082044089,
        CHAR_Gloomrot_SpiderTank_Driller = 709450349,
        CHAR_Gloomrot_SpiderTank_Gattler = -884401089,
        CHAR_Gloomrot_SpiderTank_LightningRod = 1655577903,
        CHAR_Gloomrot_SpiderTank_Zapper = -2018710724,
        CHAR_Gloomrot_Tazer = 674807351,
        CHAR_Gloomrot_Tazer_Servant = -924080115,
        CHAR_Gloomrot_Technician = 820492683,
        CHAR_Gloomrot_Technician_Labworker = -825299465,
        CHAR_Gloomrot_Technician_Labworker_Servant = -1034892278,
        CHAR_Gloomrot_Technician_Servant = -775762125,
        CHAR_Gloomrot_TheProfessor_VBlood = 814083983,
        CHAR_Gloomrot_TractorBeamer = -293507834,
        CHAR_Gloomrot_TractorBeamer_Servant = 565869317,
        CHAR_Gloomrot_Villager_Female = 1216169364,
        CHAR_Gloomrot_Villager_Female_Servant = -1192403515,
        CHAR_Gloomrot_Villager_Male = -732208863,
        CHAR_Gloomrot_Villager_Male_Servant = -2085282780,
        CHAR_Gloomrot_Voltage_VBlood = -1101874342,
        CHAR_Harpy_Dasher = -1846851895,
        CHAR_Harpy_Dasher_SUMMON = 1635780151,
        CHAR_Harpy_FeatherDuster = -1407234470,
        CHAR_Harpy_Matriarch_VBlood = 685266977,
        CHAR_Harpy_Scratcher = 1462269123,
        CHAR_Harpy_Sorceress = 1224283123,
        CHAR_IceElemental = 302393064,
        CHAR_Illusion_Mosquito = -303396552,
        CHAR_IronGolem = 763796308,
        CHAR_Manticore_HomePos = 980068444,
        CHAR_Manticore_VBlood = -393555055,
        CHAR_Mantrap_Dull = -878541676,
        CHAR_Mantrap_Nest = 2016963774,
        CHAR_Mantrap_Standard = 173817657,
        CHAR_Militia_BellRinger = -1670130821,
        CHAR_Militia_BellRinger_Servant = -1433235567,
        CHAR_Militia_BishopOfDunley_VBlood = -680831417,
        CHAR_Militia_Bomber = 847893333,
        CHAR_Militia_Bomber_Servant = 232701971,
        CHAR_Militia_ConstrainingPole = 85290673,
        CHAR_Militia_Crossbow = 956965183,
        CHAR_Militia_Crossbow_Servant = 1481842114,
        CHAR_Militia_Crossbow_Summon = 2036785949,
        CHAR_Militia_Devoted = 1660801216,
        CHAR_Militia_Devoted_Servant = -823557242,
        CHAR_Militia_EyeOfGod = -1254618756,
        CHAR_Militia_Glassblower_VBlood = 910988233,
        CHAR_Militia_Guard = 1730498275,
        CHAR_Militia_Guard_Servant = -1447279513,
        CHAR_Militia_Guard_Summon = 1050151632,
        CHAR_Militia_Guard_VBlood = -29797003,
        CHAR_Militia_Heavy = 2005508157,
        CHAR_Militia_Heavy_Servant = -1773935659,
        CHAR_Militia_Hound = -249647316,
        CHAR_Militia_Hound_VBlood = -1373413273,
        CHAR_Militia_HoundMaster_VBlood = -784265984,
        CHAR_Militia_InkCrawler = 2090982759,
        CHAR_Militia_Leader_VBlood = 1688478381,
        CHAR_Militia_Light = -63435588,
        CHAR_Militia_Light_Servant = 169329980,
        CHAR_Militia_Light_Summon = 1772451421,
        CHAR_Militia_Longbowman = 203103783,
        CHAR_Militia_Longbowman_LightArrow_Vblood = 850622034,
        CHAR_Militia_Longbowman_Servant = -242295780,
        CHAR_Militia_Longbowman_Summon = 1083647444,
        CHAR_Militia_Miner_Standard = -1072754152,
        CHAR_Militia_Miner_Standard_Servant = -1363137425,
        CHAR_Militia_Nun = -700632469,
        CHAR_Militia_Nun_VBlood = -99012450,
        CHAR_Militia_Scribe_VBlood = 1945956671,
        CHAR_Militia_Torchbearer = 37713289,
        CHAR_Militia_Torchbearer_Servant = 986768339,
        CHAR_Militia_Undead_Infiltrator = -614820237,
        CHAR_Monster_LightningPillar = -1977168943,
        CHAR_Mount_Horse = 1149585723,
        CHAR_Mount_Horse_Gloomrot = 1213710323,
        CHAR_Mount_Horse_Spectral = 2022889449,
        CHAR_Mount_Horse_Vampire = -1502865710,
        CHAR_Mutant_Bear_Standard = 1938756250,
        CHAR_Mutant_FleshGolem = 823276204,
        CHAR_Mutant_RatHorror = -375581934,
        CHAR_Mutant_Spitter = 1092792896,
        CHAR_Mutant_Wolf = 572729167,
        CHAR_NecromancyDagger_SkeletonBerserker_Armored_Farbane = -825517671,
        CHAR_Paladin_DivineAngel = -1737346940,
        CHAR_Paladin_FallenAngel = -76116724,
        CHAR_Pixie = 1434914085,
        CHAR_Poloma_VBlood = -484556888,
        CHAR_RockElemental = 20817667,
        CHAR_Scarecrow = -1750347680,
        CHAR_Spectral_Guardian = 304726480,
        CHAR_Spectral_SpellSlinger = 2065149172,
        CHAR_Spider_Baneling = -764515001,
        CHAR_Spider_Baneling_Summon = -1004061470,
        CHAR_Spider_Broodmother = 342127250,
        CHAR_Spider_Forest = -581295882,
        CHAR_Spider_Forestling = 574276383,
        CHAR_Spider_Melee = 2136899683,
        CHAR_Spider_Melee_Summon = 2119230788,
        CHAR_Spider_Queen_VBlood = -548489519,
        CHAR_Spider_Range = 2103131615,
        CHAR_Spider_Range_Summon = 1974733695,
        CHAR_Spider_Spiderling = 1078424589,
        CHAR_Spider_Spiderling_VerminNest = 1767714956,
        CHAR_Spiderling_Summon = -18289884,
        CHAR_StoneGolem = -779411607,
        CHAR_SUMMON_Wolf = 1825512527,
        CHAR_TargetDummy_Footman = 1479720323,
        CHAR_Trader_Dunley_Gems_T02 = 194933933,
        CHAR_Trader_Dunley_Herbs_T02 = 233171451,
        CHAR_Trader_Dunley_Knowledge_T02 = 281572043,
        CHAR_Trader_Dunley_RareGoods_T02 = -1594911649,
        CHAR_Trader_Farbane_Gems_T01 = -1168705805,
        CHAR_Trader_Farbane_Herbs_T01 = -375258845,
        CHAR_Trader_Farbane_Knowledge_T01 = -208499374,
        CHAR_Trader_Farbane_RareGoods_T01 = -1810631919,
        CHAR_Trader_Legendary_T04 = -1292194494,
        CHAR_Trader_Silverlight_Gems_T03 = -1990875761,
        CHAR_Trader_Silverlight_Herbs_T03 = 1687896942,
        CHAR_Trader_Silverlight_Knowledge_T03 = -915182578,
        CHAR_Trader_Silverlight_RareGoods_T03 = 739223277,
        CHAR_Treant = -1089337069,
        CHAR_Undead_ArmoredSkeletonCrossbow_Dunley = -861407720,
        CHAR_Undead_ArmoredSkeletonCrossbow_Farbane = -195077008,
        CHAR_Undead_Assassin = -1365627158,
        CHAR_Undead_BishopOfDeath_VBlood = 577478542,
        CHAR_Undead_BishopOfShadows_VBlood = 939467639,
        CHAR_Undead_CursedSmith_FloatingWeapon_Base = -1099451233,
        CHAR_Undead_CursedSmith_FloatingWeapon_Mace = -55245645,
        CHAR_Undead_CursedSmith_FloatingWeapon_Slashers = 769910415,
        CHAR_Undead_CursedSmith_FloatingWeapon_Spear = 233127264,
        CHAR_Undead_CursedSmith_FloatingWeapon_Sword = -2020619708,
        CHAR_Undead_CursedSmith_VBlood = 326378955,
        CHAR_Undead_FlyingSkull = -236166535,
        CHAR_Undead_GhostAssassin = 849891426,
        CHAR_Undead_GhostBanshee = -1146194149,
        CHAR_Undead_GhostBanshee_TombSummon = 414648299,
        CHAR_Undead_GhostGuardian = -458883491,
        CHAR_Undead_GhostMilitia_Crossbow = -85729652,
        CHAR_Undead_GhostMilitia_Crossbow_Summon = 348038236,
        CHAR_Undead_GhostMilitia_Light = -1618703048,
        CHAR_Undead_GhostMilitia_Light_Summon = 1684831595,
        CHAR_Undead_Ghoul_Armored_Farmlands = 2105565286,
        CHAR_Undead_Ghoul_TombSummon = 937597711,
        CHAR_Undead_Guardian = -1967480038,
        CHAR_Undead_Infiltrator_AfterShadow = -558928562,
        CHAR_Undead_Infiltrator_VBlood = 613251918,
        CHAR_Undead_Leader_Vblood = -1365931036,
        CHAR_Undead_Necromancer = -572568236,
        CHAR_Undead_Necromancer_TombSummon = 2025660438,
        CHAR_Undead_Priest = -1653554504,
        CHAR_Undead_Priest_VBlood = 153390636,
        CHAR_Undead_RottingGhoul = -1722506709,
        CHAR_Undead_ShadowSoldier = 678628353,
        CHAR_Undead_SkeletonApprentice = -1789347076,
        CHAR_Undead_SkeletonCrossbow_Base = 597386568,
        CHAR_Undead_SkeletonCrossbow_Farbane_OLD = 1250474035,
        CHAR_Undead_SkeletonCrossbow_GolemMinion = 1706319681,
        CHAR_Undead_SkeletonCrossbow_Graveyard = 1395549638,
        CHAR_Undead_SkeletonGolem = -1380216646,
        CHAR_Undead_SkeletonMage = -1287507270,
        CHAR_Undead_SkeletonSoldier_Armored_Dunley = 952695804,
        CHAR_Undead_SkeletonSoldier_Armored_Farbane = -837329073,
        CHAR_Undead_SkeletonSoldier_Base = -603934060,
        CHAR_Undead_SkeletonSoldier_GolemMinion = 343833814,
        CHAR_Undead_SkeletonSoldier_Infiltrator = -1642110920,
        CHAR_Undead_SkeletonSoldier_TombSummon = -259591573,
        CHAR_Undead_SkeletonSoldier_Unholy_Minion = -1779239433,
        CHAR_Undead_SkeletonSoldier_Withered = -1584807109,
        CHAR_Undead_UndyingGhoul = 1640311129,
        CHAR_Undead_ZealousCultist_Ghost = 128488545,
        CHAR_Undead_ZealousCultist_VBlood = -1208888966,
        CHAR_Unholy_Baneling = -1823987835,
        CHAR_Unholy_DeathKnight = 1857865401,
        CHAR_Unholy_FallenAngel = -1928607398,
        CHAR_Unholy_SkeletonApprentice_Summon = 722671522,
        CHAR_Unholy_SkeletonWarrior_Summon = 1604500740,
        CHAR_Vampire_Withered = -1117581429,
        CHAR_Vampire_WitheredBatMinion = -989999571,
        CHAR_VampireMale = 38526109,
        CHAR_Vermin_DireRat_VBlood = -2039908510,
        CHAR_Vermin_GiantRat = -1722278689,
        CHAR_Vermin_WickedRat_Rare = -19165577,
        CHAR_VHunter_Jade_VBlood = -1968372384,
        CHAR_VHunter_Leader_VBlood = -1449631170,
        CHAR_Villager_CursedWanderer_VBlood = 109969450,
        CHAR_Villager_Tailor_VBlood = -1942352521,
        CHAR_Wendigo_VBlood = 24378719,
        CHAR_Werewolf = -1554760905,
        CHAR_WerewolfChieftain_Human = -1505705712,
        CHAR_WerewolfChieftain_ShadowClone = -1699898875,
        CHAR_WerewolfChieftain_VBlood = -1007062401,
        CHAR_Winter_Bear_Standard = 2041915372,
        CHAR_Winter_Moose = -779632831,
        CHAR_Winter_Wolf = 134039094,
        CHAR_Winter_Yeti_VBlood = -1347412392,
    };

    public enum Buffs {
        Buff_Bandit_Worker_Shared_Wounded = -1169480604,
        Buff_Base = -1761213251,
        Buff_Base_BloodQuality = 1691282284,
        Buff_Base_Channeling_Ticks = -222270535,
        Buff_BatVampire_InCombat = -1818876607,
        Buff_BatVampire_Wounded_Buff = 846762364,
        Buff_BloodAltar_TrackVBloodUnit = -1458480041,
        Buff_BloodBuff_Assault = -646796985,
        Buff_BloodBuff_CriticalStrike = 1536493953,
        Buff_BloodBuff_Empower = 1096233037,
        Buff_BloodBuff_FadingHaste = 2131895379,
        Buff_BloodBuff_FreeCast = 1564305682,
        Buff_BloodFountain_FadingHaste = 219224509,
        Buff_BloodMoon = -560523291,
        Buff_BloodQuality_T01_OLD = 68256796,
        Buff_BloodQuality_T02_OLD = -1678486319,
        Buff_BloodQuality_T03_OLD = -1132025074,
        Buff_BloodQuality_T04_OLD = 1894166679,
        Buff_BloodQuality_T05_OLD = 1388654603,
        Buff_BounceDelay_Base = -479631449,
        Buff_Building_Siege_ActivationTimer_Buff_Base = -1650963283,
        Buff_Building_Siege_ActivationTimer_Buff_T01 = -2007316848,
        Buff_Building_Siege_ActivationTimer_Buff_T02 = -1602570831,
        Buff_Building_Siege_Active_Buff = 40754527,
        Buff_Cardinal_Shield_Stack = 636817215,
        Buff_ChurchOfLight_Cardinal_VBlood_Downed = 334972667,
        Buff_ChurchOfLight_CardinalAide_Block_HasBlocked = 859409812,
        Buff_ChurchOfLight_Cleric_Block_HasBlocked = 1896858104,
        Buff_ChurchOfLight_Cleric_Intervene_Shield = 514720473,
        Buff_ChurchOfLight_Flee_Bellringer = -1202486333,
        Buff_ChurchOfLight_Flee_Villager_Female = 111464415,
        Buff_ChurchOfLight_Flee_Villager_Male = 1904904415,
        Buff_ChurchOfLight_Knight_2H_MovementUsed = -2109458830,
        Buff_ChurchOfLight_Overseer_MinionAggro = -1787328614,
        Buff_ChurchOfLight_Overseer_VBlood_Downed = 1136634549,
        Buff_ChurchOfLight_Paladin_FinalStageBuff = 2144624015,
        Buff_ChurchOfLight_Paladin_ImmaterialHomePos = 293087822,
        Buff_ChurchOfLight_Paladin_OnAggroAnimation = -1299085096,
        Buff_ChurchOfLight_Paladin_Return = -1435372081,
        Buff_ChurchOfLight_Paladin_VBlood_Downed = 351185022,
        Buff_ChurchOfLight_SlaveMaster_HideWhip_Buff = -1104282069,
        Buff_ChurchOfLight_Sommelier_VBlood_Downed = -2037971116,
        Buff_ChurchOfLight_Villager_Cover_Female = 1423858323,
        Buff_ChurchOfLight_Villager_Cover_Male = -167087059,
        Buff_CombatStance = -952067173,
        Buff_ComboBuffA = -960097294,
        Buff_ComboBuffB = 917058375,
        Buff_ComboBuffB2 = 1082027099,
        Buff_ComboBuffC = -1018709766,
        Buff_Cover_Base = -665834590,
        Buff_Cultist_BloodFrenzy_Buff = -106492795,
        Buff_CursedWanderer_VBlood_Flee = 573463911,
        Buff_Delayed_Coffin_Destroy = 2096715241,
        Buff_Devoted_CircleMovement = -581099651,
        Buff_Elemental_Active_Base = -1124158800,
        Buff_Farbane_Trader_HideBackbling = 1871900432,
        Buff_Farbane_Trader_HideWeapons = -724071729,
        Buff_Flee_Base = -713982875,
        Buff_Footman_MovementUsed = 1967011140,
        Buff_General_Amplify = 128529083,
        Buff_General_BloodBuff_RogueAmplify = -752572494,
        Buff_General_BounceDelay = 1097461278,
        Buff_General_Build_Spawn_Buff_Immaterial = 1360141727,
        Buff_General_Build_Spawn_Buff_WeakStructure = 237078863,
        Buff_General_Build_Spawn_Buff_WeakStructure_Wall = 740689171,
        Buff_General_Chill = -1974768686,
        Buff_General_CurseOfTheForest_Area = 821183186,
        Buff_General_Daze = 792451792,
        Buff_General_Disconnected = 1769215014,
        Buff_General_DisconnectedTemporaryImmunity = 915954162,
        Buff_General_Entangled = -1270359452,
        Buff_General_FadingHaste = -1911970959,
        Buff_General_FadingSnare = 1276262777,
        Buff_General_Fear = 695136154,
        Buff_General_FearWithoutDamageCap = 1416250466,
        Buff_General_Freeze = -948292568,
        Buff_General_Freeze_HighDamageTreshold = 399565845,
        Buff_General_Garlic_Area_Base = 434938627,
        Buff_General_Garlic_Area_Inside = -1701323826,
        Buff_General_Garlic_Fever = 1582196539,
        Buff_General_Gloomrot_LightningFadingSnare = -741376672,
        Buff_General_Gloomrot_LightningStun = 469128628,
        Buff_General_Gloomrot_Static = -2067402784,
        Buff_General_Haste = 900030866,
        Buff_General_HideCorpse = 1160901934,
        Buff_General_Holy_Area_T01 = 1593142604,
        Buff_General_Holy_Area_T02 = -621774510,
        Buff_General_Holy_AreaDamage_Prog = -1532362646,
        Buff_General_Ignite = 1533067119,
        Buff_General_Immaterial = 227784838,
        Buff_General_Immobilize = -1548063130,
        Buff_General_InAir_Landing = 129112290,
        Buff_General_Incapacitate = -211448091,
        Buff_General_Incapacitate_ImpactFX = 796254181,
        Buff_General_Incapacitate_ImpactFX_NoDiminishingReturn = 552294046,
        Buff_General_Knockback = -984195038,
        Buff_General_Knockback_Ally = -2099203048,
        Buff_General_Knockback_ExpandFire = -319767548,
        Buff_General_Knockback_WallTrigger = -1483130162,
        Buff_General_Knockback_Wind = -1505593036,
        Buff_General_LockRotation = -814835059,
        Buff_General_NoAnimationKnockback = -1266751732,
        Buff_General_Petrify = 1161081043,
        Buff_General_Phasing = -79611032,
        Buff_General_Poison = 1728652937,
        Buff_General_PvPProtected = 1111481396,
        Buff_General_RelicCarryDebuff = -714279777,
        Buff_General_SelfStun = -704735901,
        Buff_General_SemiTransparent = 1511101848,
        Buff_General_Shapeshift_Base = 32037890,
        Buff_General_Shapeshift_IntoVillager = -1845915827,
        Buff_General_Shapeshift_IntoVillagerChieftain = -1408868059,
        Buff_General_Shapeshift_IntoWerewolf = -1366668190,
        Buff_General_Shapeshift_IntoWerewolfChieftain = 984412445,
        Buff_General_Shield = -1968422421,
        Buff_General_Silence = 385404312,
        Buff_General_Silver_Sickness_Burn_Debuff = 853298599,
        Buff_General_SilverSlave = 103615205,
        Buff_General_SilverSlaveCover = -1274403808,
        Buff_General_SilverSlaveReleased = 1229176670,
        Buff_General_SilverSlaveRun = 1793107442,
        Buff_General_SleepingIdle_Base = -2636972,
        Buff_General_Sludge_Poison = -1965215729,
        Buff_General_Spawn_Unit = 396339796,
        Buff_General_Spawn_Unit_Fast = 507944752,
        Buff_General_Spawn_VBlood_AlphaWolf = 600470494,
        Buff_General_Spawn_VBlood_EarlyGame = -703593639,
        Buff_General_Spawn_VBlood_EndGame = -2071666138,
        Buff_General_Spawn_VBlood_FirstBandits = 148706785,
        Buff_General_Spawn_VBlood_MidGame = -184730451,
        Buff_General_Spawn_VBlood_ShardBosses = -1163165749,
        Buff_General_Spectral_Weaken_ZealousCultist = 1224796284,
        Buff_General_SpellBlock = -666744738,
        Buff_General_SpellBlockSilence = -1351580266,
        Buff_General_Stagger = 1060841159,
        Buff_General_Station_Repair = -359018142,
        Buff_General_Stun = 355774169,
        Buff_General_Stun_EMP = 803170994,
        Buff_General_Stun_ImpactFX = -1369764436,
        Buff_General_Stun_KnockedDownRise = 578821520,
        Buff_General_Stun_MonsterGateTrigger = 1884055278,
        Buff_General_Stun_Self_MilitiaLeader = -564937730,
        Buff_General_Tank_LaunchPilot = -1891612854,
        Buff_General_Tank_LaunchPilotStun = 797548263,
        Buff_General_Tank_PilotAttach = -1041125977,
        Buff_General_Teleport_Travel = -474441982,
        Buff_General_Throne_Busy = 1845376969,
        Buff_General_TimeOut_Despawn = -1953483362,
        Buff_General_Transformation = -448293316,
        Buff_General_Vampire_Wounded_Buff = -1992158531,
        Buff_General_VampireMount_Dead = 525019977,
        Buff_General_VampirePvPDeathDebuff = 1591132469,
        Buff_General_VBlood_Downed = -806335869,
        Buff_General_VBlood_Ghost_Timer = 1689183691,
        Buff_General_Wall_Repair = 1244705549,
        Buff_General_Weaken = -1841976861,
        Buff_General_Weaken_Cursed_Ghosts = -966736642,
        Buff_General_WeakeningHolyFlames = -1209669293,
        Buff_General_Weapon_M1_ReadyFX = -1285705156,
        Buff_General_WeaponCharge = 730713184,
        Buff_General_WeaponChargeReady = -516008436,
        Buff_General_Wounded_Tracker = 224060472,
        Buff_Geomancer_Shield_Stack = -1864993435,
        Buff_Gloomrot_Iva_VBlood_Downed = -764330540,
        Buff_Gloomrot_Monster_VBlood_Downed = -1883912949,
        Buff_Gloomrot_Professor_VBlood_Downed = -1736795990,
        Buff_Gloomrot_RailgunSergeant_ImmaterialHomePos = -1203425149,
        Buff_Gloomrot_RailgunSergeant_VBlood_Downed = 1251197221,
        Buff_Gloomrot_SentryOfficer_HasTurret = 185404345,
        Buff_Gloomrot_SentryOfficer_TurretCooldown = -1541207161,
        Buff_Gloomrot_Voltage_HideWhip = -1716622857,
        Buff_Gloomrot_Voltage_Return = -1773136595,
        Buff_Gloomrot_Voltage_VBlood_Downed = 1682893847,
        Buff_HitBuff_Base = 1868153244,
        Buff_HoundMaster_DeathTrackingBuff = 2062815630,
        Buff_Illusion_Mosquito_DisableAggro = 1934061152,
        Buff_ImprisonTravel = 379796791,
        Buff_InCombat = 581443919,
        Buff_InCombat_ChurchOfLight_Paladin = -158349491,
        Buff_InCombat_DivineAngel = 1420967901,
        Buff_InCombat_Forest_Wolf = 195947260,
        Buff_InCombat_Gloomrot_RailgunSergeant = -112425228,
        Buff_InCombat_Manticore = -1360686341,
        Buff_InCombat_Npc = 480749717,
        Buff_InCombat_Npc_Boss = -1691569035,
        Buff_InCombat_Npc_CoverSlave = -223678683,
        Buff_InCombat_Npc_Elite = 1227555070,
        Buff_InCombat_Npc_Invulernable = 544892542,
        Buff_InCombat_Npc_LessHpScaling = 680803070,
        Buff_InCombat_Npc_Monster = 257768416,
        Buff_InCombat_Npc_Servant = -562438568,
        Buff_InCombat_Npc_Summon = 1141461369,
        Buff_InCombat_PvPVampire = 697095869,
        Buff_InCombat_TheProfessor = -1781177443,
        Buff_InCombat_Trader_T01 = -20088559,
        Buff_InCombat_Trader_T0203 = -723142953,
        Buff_InCombat_VBlood_Armorer = 1958910703,
        Buff_InCombat_VBlood_Bandit_Bomber = 1514481038,
        Buff_InCombat_VBlood_BanditLeader = -282443267,
        Buff_InCombat_VBlood_Bear_Dire = 1960737087,
        Buff_InCombat_VBlood_BishopOfDeath = -1410079457,
        Buff_InCombat_VBlood_BishopOfDunley = 294077942,
        Buff_InCombat_VBlood_BishopOfShadows = -219121351,
        Buff_InCombat_VBlood_Chaosarrow = -2137397598,
        Buff_InCombat_VBlood_ChurchOfLight_Cardinal = 22992735,
        Buff_InCombat_VBlood_CursedWanderer = -163001676,
        Buff_InCombat_VBlood_DireRat = -258353694,
        Buff_InCombat_VBlood_Foreman = -1200676651,
        Buff_InCombat_VBlood_Frostarrow = -2060227403,
        Buff_InCombat_VBlood_Geomancer_Golem = -499398870,
        Buff_InCombat_VBlood_Geomancer_Human = -1352713778,
        Buff_InCombat_VBlood_Harpy_Matriarch = 78907725,
        Buff_InCombat_VBlood_Iva = -1784269994,
        Buff_InCombat_VBlood_Militia_Glassblower = -54441856,
        Buff_InCombat_VBlood_Militia_Guard = -1953643558,
        Buff_InCombat_VBlood_Militia_Leader = -882307775,
        Buff_InCombat_VBlood_Militia_LightArrow = 1026827463,
        Buff_InCombat_VBlood_Militia_Scribe = 447801882,
        Buff_InCombat_VBlood_MountainBeast = 1683300592,
        Buff_InCombat_VBlood_Nun = -1716617716,
        Buff_InCombat_VBlood_Overseer = 1860175001,
        Buff_InCombat_VBlood_Poloma = -1054878413,
        Buff_InCombat_VBlood_Purifier = 437878287,
        Buff_InCombat_VBlood_Sommelier = 978693389,
        Buff_InCombat_VBlood_Spider_Queen = -584450365,
        Buff_InCombat_VBlood_StoneBreaker = -955739317,
        Buff_InCombat_VBlood_Tailor = -750658096,
        Buff_InCombat_VBlood_ToadKing = 52223855,
        Buff_InCombat_VBlood_Tourok = 449194487,
        Buff_InCombat_VBlood_Undead_Priest = 747679525,
        Buff_InCombat_VBlood_Voltage = -525986975,
        Buff_InCombat_VBlood_Wendigo = 989251425,
        Buff_InCombat_VBlood_WerewolfChieftain_Werewolf = 1287682259,
        Buff_InCombat_VBlood_Witch = -1219399206,
        Buff_InCombat_VBlood_Yeti = -1814423891,
        Buff_InCombat_VHunter_Jade = 170721886,
        Buff_InkCrawler_Timer = 1273155981,
        Buff_Interrupt = 21644547,
        Buff_Iva_WeaponEquip_Base = -1852652593,
        Buff_Iva_WeaponEquip_Flamer = 847337272,
        Buff_Iva_WeaponEquip_HideAll = -1584074836,
        Buff_Iva_WeaponEquip_Shotgun = 1905993695,
        Buff_Iva_WeaponEquip_Tazer = -1463058911,
        Buff_Manticore_ImmaterialHomePos = -61473528,
        Buff_Manticore_VBlood_Downed = -195747592,
        Buff_Militia_BishopOfDunley_VBlood_Downed = -1684198551,
        Buff_Militia_GlassBlower_VBlood_Downed = 315631033,
        Buff_Militia_Hound_InCombat = -2046372355,
        Buff_Militia_InkCrawler_SpawnBuff = -1355571683,
        Buff_Militia_InkCrawler_TrailEffect = -1124645803,
        Buff_Militia_Scribe_HideStaff = 2053361366,
        Buff_Militia_Scribe_VBlood_Downed = 394037137,
        Buff_Monster_EnergyBeam_HasHitMonster = 799200692,
        Buff_Monster_EnergyBeam_Hit = -1568995091,
        Buff_Monster_EnergyBeam_MonsterStun = 713582764,
        Buff_Monster_FinalStage = -85146953,
        Buff_Monster_FinalStage_Empowered = 1237097606,
        Buff_Monster_FinalStage_Transition = -2079981449,
        Buff_Monster_GeneratorActive = -1548542301,
        Buff_Monster_GloomrotMilitary_Cooldown = 25784872,
        Buff_Monster_MainStage1 = 259890464,
        Buff_Monster_MainStage2 = 719241057,
        Buff_Monster_MainStage3 = -298421901,
        Buff_Monster_OnAggro = 1416123699,
        Buff_Monster_OnRelease = 1260207051,
        Buff_Monster_RecentlyReleased = 913622234,
        Buff_Monster_Return = 1089939900,
        Buff_Monster_Return_Hidebuff = -1165237844,
        Buff_Monster_ShowMechArm = 96896444,
        Buff_Monster_Tazer_BounceDelay = 1051593309,
        Buff_Monster_ThresholdInterrupt = -1791833910,
        Buff_MountainBeast_DashRotationImpair = -748506838,
        Buff_MoveToBusStop = -1096336901,
        Buff_MoveToBusStopDestroy = 539166338,
        Buff_NoBlood_Debuff = -915894843,
        Buff_OnAggro_TheProfessor = -1368184079,
        Buff_OutOfCombat = 897325455,
        Buff_Overseer_Spawn_Minion = 263434875,
        Buff_Paladin_DivineAngel_ChaseBuff = 1277289010,
        Buff_Paladin_FallenAngel_ChaseBuff = 1586158367,
        Buff_Paladin_ShockWaveSlam_FadingSnare = 966083888,
        Buff_Prisoner_Flee_Villager_Female = -524901271,
        Buff_Prisoner_Flee_Villager_Male = -1635032699,
        Buff_Prisoner_Villager = 626943474,
        Buff_Prisoner_Villager_Cover_Female = 1216826981,
        Buff_Prisoner_Villager_Cover_Male = 20409553,
        Buff_Purifier_OutOfCombat = -698800339,
        Buff_Purifier_Return = -1983671299,
        Buff_Purifier_Wounded = 627111319,
        Buff_RemoveAfterDuration_FadeOut = -101157490,
        Buff_Shapeshift_Base = 361281067,
        Buff_Shared_HealthOrbListener_Normal = 264475473,
        Buff_Shared_Return = -560330878,
        Buff_Shared_Return_NoInvulernable = 2086395440,
        Buff_Sommelier_Emote_OnAggro_Buff = -83105343,
        Buff_SpawnBuff_Base = -2107750654,
        Buff_SpawnBuff_Skeleton_EarthCrawl = 1820474368,
        Buff_Spectral_SpellSlinger_DisableAggro = -220887892,
        Buff_Spider_Forest_Webbing_HasteBuff = -481566876,
        Buff_Spider_Forest_Webbing_SlowDebuff = 1546160943,
        Buff_Spider_Melee_Webbing_HasteBuff = -2101950327,
        Buff_Spider_Melee_Webbing_SlowDebuff = -1831802998,
        Buff_SpiderCocoon_Lifetime = -1555636522,
        Buff_SummonedSpawn_Base = -583222498,
        Buff_SummonedSpawn_General = 1013625819,
        Buff_SummonedSpawn_General_QuickSpawn = -25317698,
        Buff_Tailor_VBlood_Flee = -530519474,
        Buff_Tank_Standing_PilotAttach = -900651947,
        Buff_Undead_BishopOfShadows_VBlood_Downed = -721205311,
        Buff_Undead_CursedSmith_FloatingMace_Weaken = -502090069,
        Buff_Undead_CursedSmith_InCombat = -1977989346,
        Buff_Undead_CursedSmith_VBlood_Downed = 126339959,
        Buff_Undead_CursedSmith_Weaken = 355440213,
        Buff_Undead_FlyingSkull_LivingMaterial = -1559874083,
        Buff_Undead_Infiltrator_OutOfCombat = -27509782,
        Buff_Undead_Infiltrator_VBlood_Downed = 2075976215,
        Buff_Undead_Infiltrator_VBlood_InCombat = -1173838598,
        Buff_Undead_Infiltrator_VBlood_OnAggro = -1177340313,
        Buff_Undead_Leader_VBlood_Downed = -2002379408,
        Buff_Undead_Leader_VBlood_InCombat = -2079744569,
        Buff_Undead_Leader_VBlood_OnAggro = 710476221,
        Buff_Undead_Priest_VBlood_Downed = -1455144915,
        Buff_Undead_SkeletonGolem_MinionLifetime = -665880743,
        Buff_Undead_SkeletonGolem_MinionSpawner = -931287980,
        Buff_Undead_SkeletonGolem_SpawnAnimation = 2144295761,
        Buff_Undead_ZealousCultist_InCombat = -652831057,
        Buff_Unholy_Baneling_Spawn = -397004570,
        Buff_Unholy_DeathKnight_DisableAggro = 955278936,
        Buff_USB_Lifetime = 71525166,
        Buff_Vampire_Withered_BloodHeal = 1945916099,
        Buff_Vampire_Withered_Idle = -981202863,
        Buff_VBlood_Ability_Replace = 1171608023,
        Buff_VHunter_Jade_Impaled = 1000095932,
        Buff_VHunter_Leader_Impaled = -700008203,
        Buff_VHunter_Leader_InCombat = 521682636,
        Buff_Villager_CursedWanderer_VBlood_Downed = 1950981925,
        Buff_Voltage_Stage2 = -911970381,
        Buff_Voltage_Stage2_Transition1 = -10363246,
        Buff_Voltage_Stage2_Transition2 = -1053045898,
        Buff_Voltage_Stage2_Transition3 = -750611171,
        Buff_Waypoint_Travel = 150521246,
        Buff_Waypoint_TravelEnd = -1361133205,
        Buff_Wendigo_Freeze = 899218383,
        Buff_Werewolf_Return = -169078563,
        Buff_WerewolfChieftain_Human_InCombat = 833438332,
        Buff_WerewolfChieftain_Idle = -43198776,
        Buff_WerewolfChieftain_Return = -1511222240,
        Buff_Yeti_Freeze = -1743320328,
    };

    public enum Faction {
        Bandits = -413163549,
        Bear = 1344481611,
        ChurchOfLum = 1094603131, // HumanTown
        ChurchOfLum_Slaves = 671871002,
        ChurchOfLum_Slaves_Rioters = 877850148,
        ChurchOfLum_SpotShapeshiftVampire = 2395673, // HumanCleric
        Critters = 10678632,
        Cursed = 1522496317,
        Elementals = 1513046884,
        Gloomrot = -1632475814, // HumanGloomrot
        Harpy = 1731533561,
        Ignored = -1430861195, // Horse
        Militia = 1057375699, // HumanFarmer
        Mutants = -210606557,
        NatureSpirit = 1597367490,
        Plants = -1414061934,
        Players = 1106458752, // Summoned by player
        Players_Castle_Prisoners = -394968526,
        Players_Mutant = 2146780972,
        Players_Shapeshift_Human = -1036907707,
        Spiders = -1632009503,
        Traders_T01 = 30052367,
        Traders_T02 = 887347866,
        Undead = 929074293,
        VampireHunters = 2120169232,
        Wendigo = -535162217,
        Werewolf = -2024618997,
        WerewolfHuman = 62959306,
        Wolves = -1671358863,
        World_Prisoners = 1977351396,
        Unknown = 0,
    }
}