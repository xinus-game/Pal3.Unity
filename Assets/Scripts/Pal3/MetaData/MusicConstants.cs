// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2022, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.MetaData
{
    using System.Collections.Generic;

    public static class MusicConstants
    {
        #if PAL3
        public static readonly Dictionary<string, string> CombatMusicInfo = new()
        {
            {"m01", "PI24"},	// 璧山
            {"m02", "PI24"},	// 九龙坡
            {"m04", "PI24A"},	// 船（长江上)
            {"m03", "PI24"},	// 大渡口
            {"m05", "PI24A"},	// 船（海上）
            {"m06", "PI24A"},	// 蓬莱御剑堂
            {"m08", "PI26"},	// 九顶山
            {"m09", "PI26A"},	// 霹雳堂总舵
            {"m10", "PI26A"},	// 古藤林
            {"m11", "PI26"},	// 蜀山故道
            {"q08", "PI26"},	// 蜀山派
            {"m15", "PI26A"},	// 神魔之井
            {"m16", "PI26"},	// 神树
            {"m17", "PI26"},	// 锁妖塔
            {"m18", "PI26A"},	// 草海
            {"m19", "PI24A"},	// 灵山仙人洞
            {"m20", "PI26"},	// 熔岩地狱
            {"m21", "PI26A"},	// 黄泉路
            {"m22", "PI26"},	// 冰风谷
            {"m23", "PI26A"},	// 海底城
            {"m24", "PI26"},	// 剑冢
            {"m25", "PI26A"},	// 新仙界
            {"q09", "PI26"},	// 雷州（夜）
        };
        #elif PAL3A
        public static readonly Dictionary<string, string> CombatMusicInfo = new()
        {
            {"m01", "P54"},   // 登云麓        （仗剑）
            {"m02", "P30"},   // 地脉门户      （喧哗乱舞）
            {"m03", "P55"},   // 绿萝嶂        （仗剑·变调）
            {"m04", "P30"},   // 少阳三焦      （喧哗乱舞）
            {"m05", "P30"},   // 厥阴心包      （喧哗乱舞）
            {"m06", "P55"},   // 纳林河源      （仗剑·变调）
            {"m07", "P31"},   // 阳名百纳      （渊停岳峙）
            {"m08", "P54"},   // 双溪          （仗剑）
            {"m09", "P54"},   // 太阴归尘      （仗剑）
            {"m10", "P31"},   // 蜀山故道      （渊停岳峙）
            {"m11", "P32"},   // 锁妖塔        （怀刃浴血）
            {"m12", "P30"},   // 太阳华池      （喧哗乱舞）
            {"m13", "P32"},   // 魔界之门      （怀刃浴血）
            {"m14", "P31"},   // 少阴凝碧      （渊停岳峙）
            {"m15", "P55"},   // 月光城        （仗剑·变调）
            {"m16", "P54"},   // 少阳参天      （仗剑）
            {"m17", "P57"},   // 厥阴蔽日      （临危·变调）
            {"m18", "P31"},   // 盘古之心      （渊停岳峙）
            {"m19", "P56"},   // 里蜀山内城    （临危）
            {"m20", "P30"},   // 秘密储藏室    （喧哗乱舞）
            {"q01", "P30"},   // 唐家堡     唐家堡客栈降妖  （喧哗乱舞）
            {"q04", "P56"},   // 里蜀山外城    一场误会     （临危）
            {"q08", "P30"},   // 蜀山故道大营  军队封山     （喧哗乱舞）
        };
        #endif

        #if PAL3
        public static readonly Dictionary<string, string> SceneMusicInfo = new ()
        {
            {"q01", "PI27"},  // 渝州
            {"q02", "PI06"},  // 宾化
            {"q03", "PI22"},  // 镇江
            {"q04", "PI11"},  // 蓬莱御剑堂（后段）
            {"q05", "PI17"},  // 唐家堡（后段）
            {"q06", "PI06"},  // 德阳
            {"q07", "PI10"},  // 安宁村
            {"q08", "PI13"},  // 蜀山派
            {"q09", "PI11"},  // 雷州
            {"q10", "PI11"},  // 神界·天门
            {"q11", "PI10"},  // 蛮州
            {"q12", "PI17"},  // 古城镇
            {"q13", "PI05A"}, // 酆都
            {"q14", "PI20"},  // 鬼界外围
            {"q15", "PI05"},  // 雪岭镇
            {"q16", "PI22"},  // 安溪
            {"q17", "PI11"},  // 船

            {"m01", "PI08"},  // 璧山
            {"m02", "PI14"},  // 九龙坡
            {"m03", "PI17A"}, // 大渡口
            {"m04", "PI21"},  // 船（长江上)
            {"m05", "PI12"},  // 船（海上）
            {"m06", "PI15"},  // 蓬莱御剑堂
            {"m08", "PI05"},  // 九顶山
            {"m09", "PI16"},  // 霹雳堂总舵
            {"m10", "PI14"},  // 古藤林
            {"m11", "PI21"},  // 蜀山故道
            {"m15", "PI20"},  // 神魔之井

            {"m16", "PI08"},  // 神树
            {"m17", "PI19"},  // 锁妖塔
            {"m18", "PI10A"}, // 草海
            {"m19", "PI15"},  // 灵山仙人洞
            {"m20", "PI16"},  // 熔岩地狱
            {"m21", "PI09"},  // 黄泉路
            {"m22", "PI17A"}, // 冰风谷
            {"m23", "PI12"},  // 海底城
            {"m24", "PI03"},  // 剑冢
            {"m25", "PI08"},  // 新仙界
            {"m26", "PI15"},  // 星森

            {"q01_yn11",  "PI09"},	// 渝州永安当大仓库一层（特殊战斗关）
            {"q01_yn12",  "PI09"},	// 渝州永安当大仓库二层（特殊战斗关）
            {"q01_yn13",  "PI09"},	// 渝州永安当大仓库三层（特殊战斗关）
            {"q01_yn14",  "PI09"},	// 渝州永安当小仓库一层（特殊战斗关）
            {"q01_yn15",  "PI09"},	// 渝州永安当小仓库二层（特殊战斗关）
            {"q08_q08f",  "PI19"},	// 蜀山派（战斗关）
            {"q08_qn04f", "PI19"},	// 蜀山派（战斗关）
            {"q08_qn05f", "PI19"},	// 蜀山派（战斗关）
            {"q09_ca",    "PI09"},	// 雷州（夜）（战斗关）
            {"q09_fa",    "PI09"},	// 刺史府（夜）（特殊战斗关）
            {"q11_n10",   "PI30"},	// 蛮州女娲庙
            {"m25_3",     "PI32"},	// 新仙界三
            {"t01_t01",   "PI15"},	// 陶罐中

            {"m17_1",      "NONE"},	// 锁妖塔一层
            {"q01_ba",     "NONE"},
            {"q01_sa",     "NONE"},
            {"q01_xa",     "NONE"},
            {"q01_ya",     "NONE"},
            {"q01_yn01a",  "NONE"},
            {"q01_yn02a",  "NONE"},
            {"q01_yn09a",  "NONE"},
            {"q01_bn03a",  "NONE"},
            {"q01_bn04a",  "NONE"},
            {"q01_bn05a",  "NONE"},
            {"q01_bn06a",  "NONE"},
            {"q01_xn01a",  "NONE"},
            {"q01_xn02a",  "NONE"},
            {"q01_xn03a",  "NONE"},
            {"q01_xn04aa", "NONE"},
            {"q01_xn04ba", "NONE"},
        };
        #elif PAL3A
        public static readonly Dictionary<string, string> SceneMusicInfo = new ()
        {
            {"q01", "P03"},	      // 唐家堡  （软红千丈）
            {"q02", "P14"},	      // 蜀山    （蜀道通仙）
            {"q03", "P06"},	      // 绿萝山  （仙山梦谷）
            {"q04", "P07"},	      // 里蜀山  （妖魔道）
            {"q05", "P04"},	      // 胜州    （金戈画角）
            {"q06", "P03"},	      // 京城    （软红千丈）
            {"q07", "P41"},	      // 石村    （萧瑟霜）
            {"q08", "P04"},	      // 蜀山故道大营    （金戈画角）
            {"q09", "P59"},	      // 渝州    （玉满堂·变调）
            {"q10", "P05"},	      // 施洞    （苗乡清露）
            {"m01", "P42"},	      // 登云麓  （流转虹）
            {"m02", "P43"},	      // 地脉门户（寥落风）
            {"m03", "P44"},	      // 绿萝嶂  （幽林蔽日）
            {"m04", "P08"},	      // 少阳三焦（雷霆曲）
            {"m05", "P08"},	      // 厥阴心包（雷霆曲）
            {"m06", "P12"},	      // 纳林河源（雨过河源）
            {"m07", "P09"},	      // 阳名百纳（八荒赋）
            {"m08", "P45"},	      // 双溪    （魔神诀）
            {"m09", "P09"},	      // 太阴归尘（八荒赋）
            {"m10", "P45"},	      // 蜀山故道（步云登仙）
            {"m11", "P60"},	      // 锁妖塔  （铁索镇妖）
            {"m12", "P10"},	      // 太阳华池（水调歌）
            {"m13", "P46"},	      // 魔界之门（魔神诀）
            {"m14", "P10"},	      // 少阴凝碧（水调歌）
            {"m15", "P12"},	      // 月光城  （雨过河源）
            {"m16", "P11"},	      // 少阳参天（御风辞）
            {"m17", "P11"},	      // 厥阴蔽日（御风辞）
            {"m18", "P13"},	      // 盘古之心（问心思旧）
            {"m19", "P47"},	      // 里蜀山内城（紫鸦乌）
            {"m20", "P07"},	      // 秘密储藏室（妖魔道）

            {"q02_qy",     "NONE"},   // 蜀山夜景前山
            {"q02_hy",     "NONE"},   // 蜀山夜景后山
            {"q02_xy",     "NONE"},   // 蜀山夜景西侧
            {"q02_qty",    "NONE"},   // 蜀山夜景前山（土地脉连通后）
            {"q02_hty",    "NONE"},   // 蜀山夜景后山（土地脉连通后）
            {"q02_xty",    "NONE"},   // 蜀山夜景西侧（土地脉连通后）
            {"q02_qn01y",  "NONE"},   // 蜀山夜景藏真
            {"q02_qn02y",  "NONE"},   // 蜀山夜景凝气
            {"q02_qn05y",  "NONE"},   // 蜀山夜景经楼
            {"q02_qn06y",  "NONE"},   // 蜀山夜景剑楼
            {"q02_qn07y",  "NONE"},   // 蜀山夜景常纪房间
            {"q02_qn08y",  "NONE"},   // 蜀山夜景南宫煌房间
            {"q02_qn09y",  "NONE"},   // 蜀山夜景经库下层
            {"q02_qn10y",  "NONE"},   // 蜀山夜景经库上层
            {"q02_qn11y",  "NONE"},   // 蜀山夜景兵库
            {"q02_qn14y",  "NONE"},   // 蜀山夜景蜀山弟子单人房
            {"q02_yy",     "NONE"},   // 蜀山夜景御风台
            {"q04_wnn08y", "NONE"},   // 里蜀山秘密基地外间
            {"q04_wnn09y", "NONE"},   // 里蜀山秘密基地内间
            {"q04_ny",     "NONE"},   // 里蜀山内城夜景
            {"q04_nn02y",  "NONE"},   // 里蜀山内城燎日居所夜景
            {"q06_q06y",   "NONE"},   // 京城夜景
            {"q07_q07y",   "NONE"},	  // 石村夜景
            {"q07_n01y",   "NONE"},	  // 石村丹林医馆
            {"q07_n02y",   "NONE"},	  // 石村赤炎家厅堂
            {"q07_n03y",   "NONE"},	  // 石村赤炎家厨房
            {"q07_n04y",   "NONE"},	  // 石村赤炎家客房
            {"q10_q10y",   "NONE"},   // 施洞夜景
            {"q10_n01y",   "NONE"},   // 施洞女娲庙
            {"q10_n02y",   "NONE"},   // 施洞锦绣客栈大厅
            {"q10_n03ay",  "NONE"},   // 施洞锦绣客栈客房甲
            {"q10_n03by",  "NONE"},   // 施洞锦绣客栈客房乙
            {"q10_n04y",   "NONE"},   // 施洞锦绣烂银血渡
            {"q10_n05y",   "NONE"},   // 施洞锦绣百草药栈
            {"q10_n06y",   "NONE"},   // 施洞锦绣蜡染苗衣
            {"q11_q11y",   "NONE"},   // 旧蜀山夜景
        };
        #endif
    }
}