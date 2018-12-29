using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MapLevel : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MapLevel.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMapLevel>[] offsets = new Offset<DRMapLevel>[125];
   
            offsets[0] = DRMapLevel.CreateDRMapLevel(fbb, 1,fbb.CreateString("第1关"),fbb.CreateString("Level1"),-7.581001f,-1.4f,-4.14f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[1] = DRMapLevel.CreateDRMapLevel(fbb, 2,fbb.CreateString("第2关"),fbb.CreateString("Level2"),-5.39f,-1.4f,-4.68f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[2] = DRMapLevel.CreateDRMapLevel(fbb, 3,fbb.CreateString("第3关"),fbb.CreateString("Level3"),-3.24f,-1.24f,-4.66f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[3] = DRMapLevel.CreateDRMapLevel(fbb, 4,fbb.CreateString("第4关"),fbb.CreateString("Level4"),-3.22f,-1.35f,-6.69f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[4] = DRMapLevel.CreateDRMapLevel(fbb, 5,fbb.CreateString("第5关"),fbb.CreateString("Level5"),-3.17f,-1.4f,-8.53f,0f,0f,0f,1,fbb.CreateString("Item_Rocket"),0.4f,0);
            offsets[5] = DRMapLevel.CreateDRMapLevel(fbb, 6,fbb.CreateString("第6关"),fbb.CreateString("Level6"),-3.16f,-1.4f,-11.41f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[6] = DRMapLevel.CreateDRMapLevel(fbb, 7,fbb.CreateString("第7关"),fbb.CreateString("Level7"),-3.16f,-1.24f,-13.78f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[7] = DRMapLevel.CreateDRMapLevel(fbb, 8,fbb.CreateString("第8关"),fbb.CreateString("Level8"),-1.11f,-1.35f,-13.84f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[8] = DRMapLevel.CreateDRMapLevel(fbb, 9,fbb.CreateString("第9关"),fbb.CreateString("Level9"),1.01f,-1.4f,-13.38f,0f,0f,0f,1,fbb.CreateString("Tetris_P_small"),0.4f,0);
            offsets[9] = DRMapLevel.CreateDRMapLevel(fbb, 10,fbb.CreateString("第10关"),fbb.CreateString("Level10"),3.38f,-1.4f,-13.99f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[10] = DRMapLevel.CreateDRMapLevel(fbb, 11,fbb.CreateString("第11关"),fbb.CreateString("Level11"),3.21f,-1.24f,-15.9f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[11] = DRMapLevel.CreateDRMapLevel(fbb, 12,fbb.CreateString("第12关"),fbb.CreateString("Level12"),3.23f,-1.35f,-18.21f,0f,0f,0f,4,fbb.CreateString("Item_ghost"),0.4f,0);
            offsets[12] = DRMapLevel.CreateDRMapLevel(fbb, 13,fbb.CreateString("第13关"),fbb.CreateString("Level13"),3.23f,0.65f,-20.97f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,1);
            offsets[13] = DRMapLevel.CreateDRMapLevel(fbb, 14,fbb.CreateString("第14关"),fbb.CreateString("Level14"),3.26f,0.61f,-23.6f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[14] = DRMapLevel.CreateDRMapLevel(fbb, 15,fbb.CreateString("第15关"),fbb.CreateString("Level15"),5.386f,0.665f,-23.582f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[15] = DRMapLevel.CreateDRMapLevel(fbb, 16,fbb.CreateString("第16关"),fbb.CreateString("Level16"),7.5f,0.58f,-23.6f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[16] = DRMapLevel.CreateDRMapLevel(fbb, 17,fbb.CreateString("第17关"),fbb.CreateString("Level17"),9.59f,0.57f,-23.21f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[17] = DRMapLevel.CreateDRMapLevel(fbb, 18,fbb.CreateString("第18关"),fbb.CreateString("Level18"),9.62f,0.52f,-25.76f,270f,270f,0f,2,fbb.CreateString("ItemUniversalBlock"),0.4f,0);
            offsets[18] = DRMapLevel.CreateDRMapLevel(fbb, 19,fbb.CreateString("第19关"),fbb.CreateString("Level19"),9.6f,0.62f,-28f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[19] = DRMapLevel.CreateDRMapLevel(fbb, 20,fbb.CreateString("第20关"),fbb.CreateString("Level20"),9.58f,0.55f,-30.58f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[20] = DRMapLevel.CreateDRMapLevel(fbb, 21,fbb.CreateString("第21关"),fbb.CreateString("Level21"),-7.581001f,-1.4f,-4.14f,0f,0f,0f,1,fbb.CreateString("Icon_DyedBottle"),0.4f,0);
            offsets[21] = DRMapLevel.CreateDRMapLevel(fbb, 22,fbb.CreateString("第22关"),fbb.CreateString("Level22"),-5.39f,-1.4f,-4.68f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[22] = DRMapLevel.CreateDRMapLevel(fbb, 23,fbb.CreateString("第23关"),fbb.CreateString("Level23"),-3.24f,-1.24f,-4.66f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[23] = DRMapLevel.CreateDRMapLevel(fbb, 24,fbb.CreateString("第24关"),fbb.CreateString("Level24"),-3.22f,-1.35f,-6.69f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[24] = DRMapLevel.CreateDRMapLevel(fbb, 25,fbb.CreateString("第25关"),fbb.CreateString("Level25"),-3.17f,-1.4f,-8.53f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[25] = DRMapLevel.CreateDRMapLevel(fbb, 26,fbb.CreateString("第26关"),fbb.CreateString("Level26"),-3.16f,-1.4f,-11.41f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,2);
            offsets[26] = DRMapLevel.CreateDRMapLevel(fbb, 27,fbb.CreateString("第27关"),fbb.CreateString("Level27"),-3.16f,-1.24f,-13.78f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[27] = DRMapLevel.CreateDRMapLevel(fbb, 28,fbb.CreateString("第28关"),fbb.CreateString("Level28"),-1.11f,-1.35f,-13.84f,0f,0f,0f,4,fbb.CreateString("Item_IceIcon"),0.4f,0);
            offsets[28] = DRMapLevel.CreateDRMapLevel(fbb, 29,fbb.CreateString("第29关"),fbb.CreateString("Level29"),1.01f,-1.4f,-13.38f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[29] = DRMapLevel.CreateDRMapLevel(fbb, 30,fbb.CreateString("第30关"),fbb.CreateString("Level30"),3.38f,-1.4f,-13.99f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[30] = DRMapLevel.CreateDRMapLevel(fbb, 31,fbb.CreateString("第31关"),fbb.CreateString("Level31"),3.21f,-1.24f,-15.9f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[31] = DRMapLevel.CreateDRMapLevel(fbb, 32,fbb.CreateString("第32关"),fbb.CreateString("Level32"),3.23f,-1.35f,-18.21f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[32] = DRMapLevel.CreateDRMapLevel(fbb, 33,fbb.CreateString("第33关"),fbb.CreateString("Level33"),3.23f,0.65f,-20.97f,0f,0f,0f,1,fbb.CreateString("Item_AddSteps"),0.4f,0);
            offsets[33] = DRMapLevel.CreateDRMapLevel(fbb, 34,fbb.CreateString("第34关"),fbb.CreateString("Level34"),3.26f,0.61f,-23.6f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[34] = DRMapLevel.CreateDRMapLevel(fbb, 35,fbb.CreateString("第35关"),fbb.CreateString("Level35"),5.386f,0.665f,-23.582f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[35] = DRMapLevel.CreateDRMapLevel(fbb, 36,fbb.CreateString("第36关"),fbb.CreateString("Level36"),7.5f,0.58f,-23.6f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[36] = DRMapLevel.CreateDRMapLevel(fbb, 37,fbb.CreateString("第37关"),fbb.CreateString("Level37"),9.59f,0.57f,-23.21f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[37] = DRMapLevel.CreateDRMapLevel(fbb, 38,fbb.CreateString("第38关"),fbb.CreateString("Level38"),9.62f,0.52f,-25.76f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[38] = DRMapLevel.CreateDRMapLevel(fbb, 39,fbb.CreateString("第39关"),fbb.CreateString("Level39"),9.6f,0.62f,-28f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[39] = DRMapLevel.CreateDRMapLevel(fbb, 40,fbb.CreateString("第40关"),fbb.CreateString("Level40"),9.58f,0.55f,-30.58f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[40] = DRMapLevel.CreateDRMapLevel(fbb, 41,fbb.CreateString("第41关"),fbb.CreateString("Level41"),9.57f,0.59f,-32.59f,0f,0f,0f,1,fbb.CreateString("Element_Kiss"),0.4f,0);
            offsets[41] = DRMapLevel.CreateDRMapLevel(fbb, 42,fbb.CreateString("第42关"),fbb.CreateString("Level42"),11.79f,0.51f,-33.03f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[42] = DRMapLevel.CreateDRMapLevel(fbb, 43,fbb.CreateString("第43关"),fbb.CreateString("Level43"),13.64f,0.57f,-32.98f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[43] = DRMapLevel.CreateDRMapLevel(fbb, 44,fbb.CreateString("第44关"),fbb.CreateString("Level44"),15.83f,0.515f,-32.997f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[44] = DRMapLevel.CreateDRMapLevel(fbb, 45,fbb.CreateString("第45关"),fbb.CreateString("Level45"),17.89f,0.54f,-32.58f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,1);
            offsets[45] = DRMapLevel.CreateDRMapLevel(fbb, 46,fbb.CreateString("第46关"),fbb.CreateString("Level46"),17.92f,-1.62f,-30.02f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[46] = DRMapLevel.CreateDRMapLevel(fbb, 47,fbb.CreateString("第47关"),fbb.CreateString("Level47"),19.98f,-1.53f,-29.98f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[47] = DRMapLevel.CreateDRMapLevel(fbb, 48,fbb.CreateString("第48关"),fbb.CreateString("Level48"),21.91f,-1.61f,-29.98f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[48] = DRMapLevel.CreateDRMapLevel(fbb, 49,fbb.CreateString("第49关"),fbb.CreateString("Level49"),23.97f,-1.57f,-29.59f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[49] = DRMapLevel.CreateDRMapLevel(fbb, 50,fbb.CreateString("第50关"),fbb.CreateString("Level50"),25.94f,-1.58f,-30.08f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[50] = DRMapLevel.CreateDRMapLevel(fbb, 51,fbb.CreateString("第51关"),fbb.CreateString("Level51"),-7.581001f,-1.4f,-4.14f,0f,0f,0f,1,fbb.CreateString("Item_WoodenBox1"),0.4f,0);
            offsets[51] = DRMapLevel.CreateDRMapLevel(fbb, 52,fbb.CreateString("第52关"),fbb.CreateString("Level52"),-5.39f,-1.4f,-4.68f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[52] = DRMapLevel.CreateDRMapLevel(fbb, 53,fbb.CreateString("第53关"),fbb.CreateString("Level53"),-3.24f,-1.24f,-4.66f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[53] = DRMapLevel.CreateDRMapLevel(fbb, 54,fbb.CreateString("第54关"),fbb.CreateString("Level54"),-3.22f,-1.35f,-6.69f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[54] = DRMapLevel.CreateDRMapLevel(fbb, 55,fbb.CreateString("第55关"),fbb.CreateString("Level55"),-3.17f,-1.4f,-8.53f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[55] = DRMapLevel.CreateDRMapLevel(fbb, 56,fbb.CreateString("第56关"),fbb.CreateString("Level56"),-3.16f,-1.4f,-11.41f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[56] = DRMapLevel.CreateDRMapLevel(fbb, 57,fbb.CreateString("第57关"),fbb.CreateString("Level57"),-3.16f,-1.24f,-13.78f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[57] = DRMapLevel.CreateDRMapLevel(fbb, 58,fbb.CreateString("第58关"),fbb.CreateString("Level58"),-1.11f,-1.35f,-13.84f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[58] = DRMapLevel.CreateDRMapLevel(fbb, 59,fbb.CreateString("第59关"),fbb.CreateString("Level59"),1.01f,-1.4f,-13.38f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[59] = DRMapLevel.CreateDRMapLevel(fbb, 60,fbb.CreateString("第60关"),fbb.CreateString("Level60"),3.38f,-1.4f,-13.99f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[60] = DRMapLevel.CreateDRMapLevel(fbb, 61,fbb.CreateString("第61关"),fbb.CreateString("Level61"),3.21f,-1.24f,-15.9f,270f,270f,0f,3,fbb.CreateString("Element_CandyPaper"),0.4f,0);
            offsets[61] = DRMapLevel.CreateDRMapLevel(fbb, 62,fbb.CreateString("第62关"),fbb.CreateString("Level62"),3.23f,-1.35f,-18.21f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[62] = DRMapLevel.CreateDRMapLevel(fbb, 63,fbb.CreateString("第63关"),fbb.CreateString("Level63"),3.23f,0.65f,-20.97f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[63] = DRMapLevel.CreateDRMapLevel(fbb, 64,fbb.CreateString("第64关"),fbb.CreateString("Level64"),3.26f,0.61f,-23.6f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[64] = DRMapLevel.CreateDRMapLevel(fbb, 65,fbb.CreateString("第65关"),fbb.CreateString("Level65"),5.386f,0.665f,-23.582f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[65] = DRMapLevel.CreateDRMapLevel(fbb, 66,fbb.CreateString("第66关"),fbb.CreateString("Level66"),7.5f,0.58f,-23.6f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[66] = DRMapLevel.CreateDRMapLevel(fbb, 67,fbb.CreateString("第67关"),fbb.CreateString("Level67"),9.59f,0.57f,-23.21f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[67] = DRMapLevel.CreateDRMapLevel(fbb, 68,fbb.CreateString("第68关"),fbb.CreateString("Level68"),9.62f,0.52f,-25.76f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,2);
            offsets[68] = DRMapLevel.CreateDRMapLevel(fbb, 69,fbb.CreateString("第69关"),fbb.CreateString("Level69"),9.6f,0.62f,-28f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[69] = DRMapLevel.CreateDRMapLevel(fbb, 70,fbb.CreateString("第70关"),fbb.CreateString("Level70"),9.58f,0.55f,-30.58f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[70] = DRMapLevel.CreateDRMapLevel(fbb, 71,fbb.CreateString("第71关"),fbb.CreateString("Level71"),9.57f,0.59f,-32.59f,0f,0f,0f,1,fbb.CreateString("Element_Stone"),0.4f,0);
            offsets[71] = DRMapLevel.CreateDRMapLevel(fbb, 72,fbb.CreateString("第72关"),fbb.CreateString("Level72"),11.79f,0.51f,-33.03f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[72] = DRMapLevel.CreateDRMapLevel(fbb, 73,fbb.CreateString("第73关"),fbb.CreateString("Level73"),13.64f,0.57f,-32.98f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[73] = DRMapLevel.CreateDRMapLevel(fbb, 74,fbb.CreateString("第74关"),fbb.CreateString("Level74"),15.83f,0.515f,-32.997f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[74] = DRMapLevel.CreateDRMapLevel(fbb, 75,fbb.CreateString("第75关"),fbb.CreateString("Level75"),17.89f,0.54f,-32.58f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[75] = DRMapLevel.CreateDRMapLevel(fbb, 76,fbb.CreateString("第76关"),fbb.CreateString("Level76"),17.92f,-1.62f,-30.02f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[76] = DRMapLevel.CreateDRMapLevel(fbb, 77,fbb.CreateString("第77关"),fbb.CreateString("Level77"),19.98f,-1.53f,-29.98f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[77] = DRMapLevel.CreateDRMapLevel(fbb, 78,fbb.CreateString("第78关"),fbb.CreateString("Level78"),21.91f,-1.61f,-29.98f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[78] = DRMapLevel.CreateDRMapLevel(fbb, 79,fbb.CreateString("第79关"),fbb.CreateString("Level79"),23.97f,-1.57f,-29.59f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[79] = DRMapLevel.CreateDRMapLevel(fbb, 80,fbb.CreateString("第80关"),fbb.CreateString("Level80"),25.94f,-1.58f,-30.08f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[80] = DRMapLevel.CreateDRMapLevel(fbb, 81,fbb.CreateString("第81关"),fbb.CreateString("Level81"),25.93f,-1.45f,-32.33f,270f,270f,0f,3,fbb.CreateString("Element_Mouse"),0.4f,0);
            offsets[81] = DRMapLevel.CreateDRMapLevel(fbb, 82,fbb.CreateString("第82关"),fbb.CreateString("Level82"),25.95f,-1.55f,-34.84f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[82] = DRMapLevel.CreateDRMapLevel(fbb, 83,fbb.CreateString("第83关"),fbb.CreateString("Level83"),25.85f,-1.5f,-36.38f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,1);
            offsets[83] = DRMapLevel.CreateDRMapLevel(fbb, 84,fbb.CreateString("第84关"),fbb.CreateString("Level84"),25.72f,-1.49f,-38.93f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[84] = DRMapLevel.CreateDRMapLevel(fbb, 85,fbb.CreateString("第85关"),fbb.CreateString("Level85"),28f,-1.44f,-38.89f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[85] = DRMapLevel.CreateDRMapLevel(fbb, 86,fbb.CreateString("第86关"),fbb.CreateString("Level86"),30f,-1.55f,-38.88f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[86] = DRMapLevel.CreateDRMapLevel(fbb, 87,fbb.CreateString("第87关"),fbb.CreateString("Level87"),32.09f,-1.54f,-38.47f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[87] = DRMapLevel.CreateDRMapLevel(fbb, 88,fbb.CreateString("第88关"),fbb.CreateString("Level88"),32.05f,-1.56f,-41.27f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[88] = DRMapLevel.CreateDRMapLevel(fbb, 89,fbb.CreateString("第89关"),fbb.CreateString("Level89"),32.08f,-1.44f,-43.54f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[89] = DRMapLevel.CreateDRMapLevel(fbb, 90,fbb.CreateString("第90关"),fbb.CreateString("Level90"),32.08f,-1.6f,-46.36f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[90] = DRMapLevel.CreateDRMapLevel(fbb, 91,fbb.CreateString("第91关"),fbb.CreateString("Level91"),-7.581001f,-1.4f,-4.14f,0f,0f,0f,1,fbb.CreateString("Element_XiaoYing"),0.4f,0);
            offsets[91] = DRMapLevel.CreateDRMapLevel(fbb, 92,fbb.CreateString("第92关"),fbb.CreateString("Level92"),-5.39f,-1.4f,-4.68f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[92] = DRMapLevel.CreateDRMapLevel(fbb, 93,fbb.CreateString("第93关"),fbb.CreateString("Level93"),-3.24f,-1.24f,-4.66f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[93] = DRMapLevel.CreateDRMapLevel(fbb, 94,fbb.CreateString("第94关"),fbb.CreateString("Level94"),-3.22f,-1.35f,-6.69f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[94] = DRMapLevel.CreateDRMapLevel(fbb, 95,fbb.CreateString("第95关"),fbb.CreateString("Level95"),-3.17f,-1.4f,-8.53f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[95] = DRMapLevel.CreateDRMapLevel(fbb, 96,fbb.CreateString("第96关"),fbb.CreateString("Level96"),-3.16f,-1.4f,-11.41f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[96] = DRMapLevel.CreateDRMapLevel(fbb, 97,fbb.CreateString("第97关"),fbb.CreateString("Level97"),-3.16f,-1.24f,-13.78f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[97] = DRMapLevel.CreateDRMapLevel(fbb, 98,fbb.CreateString("第98关"),fbb.CreateString("Level98"),-1.11f,-1.35f,-13.84f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[98] = DRMapLevel.CreateDRMapLevel(fbb, 99,fbb.CreateString("第99关"),fbb.CreateString("Level99"),1.01f,-1.4f,-13.38f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[99] = DRMapLevel.CreateDRMapLevel(fbb, 100,fbb.CreateString("第100关"),fbb.CreateString("Level100"),3.38f,-1.4f,-13.99f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[100] = DRMapLevel.CreateDRMapLevel(fbb, 101,fbb.CreateString("第101关"),fbb.CreateString("Level101"),3.21f,-1.24f,-15.9f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[101] = DRMapLevel.CreateDRMapLevel(fbb, 102,fbb.CreateString("第102关"),fbb.CreateString("Level102"),3.23f,-1.35f,-18.21f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[102] = DRMapLevel.CreateDRMapLevel(fbb, 103,fbb.CreateString("第103关"),fbb.CreateString("Level103"),3.23f,0.65f,-20.97f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[103] = DRMapLevel.CreateDRMapLevel(fbb, 104,fbb.CreateString("第104关"),fbb.CreateString("Level104"),3.26f,0.61f,-23.6f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[104] = DRMapLevel.CreateDRMapLevel(fbb, 105,fbb.CreateString("第105关"),fbb.CreateString("Level105"),5.386f,0.665f,-23.582f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[105] = DRMapLevel.CreateDRMapLevel(fbb, 106,fbb.CreateString("第106关"),fbb.CreateString("Level106"),7.5f,0.58f,-23.6f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[106] = DRMapLevel.CreateDRMapLevel(fbb, 107,fbb.CreateString("第107关"),fbb.CreateString("Level107"),9.59f,0.57f,-23.21f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[107] = DRMapLevel.CreateDRMapLevel(fbb, 108,fbb.CreateString("第108关"),fbb.CreateString("Level108"),9.62f,0.52f,-25.76f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[108] = DRMapLevel.CreateDRMapLevel(fbb, 109,fbb.CreateString("第109关"),fbb.CreateString("Level109"),9.6f,0.62f,-28f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[109] = DRMapLevel.CreateDRMapLevel(fbb, 110,fbb.CreateString("第110关"),fbb.CreateString("Level110"),9.58f,0.55f,-30.58f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[110] = DRMapLevel.CreateDRMapLevel(fbb, 111,fbb.CreateString("第111关"),fbb.CreateString("Level111"),9.57f,0.59f,-32.59f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[111] = DRMapLevel.CreateDRMapLevel(fbb, 112,fbb.CreateString("第112关"),fbb.CreateString("Level112"),11.79f,0.51f,-33.03f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[112] = DRMapLevel.CreateDRMapLevel(fbb, 113,fbb.CreateString("第113关"),fbb.CreateString("Level113"),13.64f,0.57f,-32.98f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[113] = DRMapLevel.CreateDRMapLevel(fbb, 114,fbb.CreateString("第114关"),fbb.CreateString("Level114"),15.83f,0.515f,-32.997f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[114] = DRMapLevel.CreateDRMapLevel(fbb, 115,fbb.CreateString("第115关"),fbb.CreateString("Level115"),17.89f,0.54f,-32.58f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[115] = DRMapLevel.CreateDRMapLevel(fbb, 116,fbb.CreateString("第116关"),fbb.CreateString("Level116"),17.92f,-1.62f,-30.02f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[116] = DRMapLevel.CreateDRMapLevel(fbb, 117,fbb.CreateString("第117关"),fbb.CreateString("Level117"),19.98f,-1.53f,-29.98f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[117] = DRMapLevel.CreateDRMapLevel(fbb, 118,fbb.CreateString("第118关"),fbb.CreateString("Level118"),21.91f,-1.61f,-29.98f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[118] = DRMapLevel.CreateDRMapLevel(fbb, 119,fbb.CreateString("第119关"),fbb.CreateString("Level119"),23.97f,-1.57f,-29.59f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[119] = DRMapLevel.CreateDRMapLevel(fbb, 120,fbb.CreateString("第120关"),fbb.CreateString("Level120"),25.94f,-1.58f,-30.08f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[120] = DRMapLevel.CreateDRMapLevel(fbb, 121,fbb.CreateString("第121关"),fbb.CreateString("Level121"),25.93f,-1.45f,-32.33f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);
            offsets[121] = DRMapLevel.CreateDRMapLevel(fbb, 122,fbb.CreateString("第122关"),fbb.CreateString("Level122"),25.95f,-1.55f,-34.84f,0f,0f,0f,4,fbb.CreateString("-1"),0.4f,0);
            offsets[122] = DRMapLevel.CreateDRMapLevel(fbb, 123,fbb.CreateString("第123关"),fbb.CreateString("Level123"),25.85f,-1.5f,-36.38f,0f,0f,0f,1,fbb.CreateString("-1"),0.4f,0);
            offsets[123] = DRMapLevel.CreateDRMapLevel(fbb, 124,fbb.CreateString("第124关"),fbb.CreateString("Level124"),25.72f,-1.49f,-38.93f,270f,270f,0f,2,fbb.CreateString("-1"),0.4f,0);
            offsets[124] = DRMapLevel.CreateDRMapLevel(fbb, 125,fbb.CreateString("第125关"),fbb.CreateString("Level125"),28f,-1.44f,-38.89f,270f,270f,0f,3,fbb.CreateString("-1"),0.4f,0);

            VectorOffset dataOff = Table_MapLevel.CreateDataVector(fbb, offsets);
            var configOff = Table_MapLevel.CreateTable_MapLevel(fbb, dataOff);
            Table_MapLevel.FinishTable_MapLevelBuffer(fbb, configOff);
            using (var ms = new MemoryStream(fbb.DataBuffer.ToFullArray(), fbb.DataBuffer.Position, fbb.Offset))
            {
                try
                {
                    var data = ms.ToArray();
                    File.WriteAllBytes(path, data);
                    Console.WriteLine("已生成:" + path.ToString());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
        }
    }
}