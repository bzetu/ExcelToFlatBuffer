using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Element : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Element.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRElement>[] offsets = new Offset<DRElement>[39];
   
            offsets[0] = DRElement.CreateDRElement(fbb, 1,fbb.CreateString("element横"),60009,10001,11001,12001,0,0,0,2,fbb.CreateString("HorizontalAndVerticalElement"),fbb.CreateString("Finder"),0,1,true,true,true,false,false,false,1,1);
            offsets[1] = DRElement.CreateDRElement(fbb, 2,fbb.CreateString("element竖"),60009,10002,11002,12002,0,0,0,2,fbb.CreateString("HorizontalAndVerticalElement"),fbb.CreateString("Finder"),1,1,true,true,true,false,false,false,1,1);
            offsets[2] = DRElement.CreateDRElement(fbb, 3,fbb.CreateString("Item_WoodenBox3木箱"),60012,10003,11003,12003,5,0,0,1,fbb.CreateString("EliminateElement"),fbb.CreateString("WoodenBoxFinder"),-1,0,true,true,false,true,false,true,3,1);
            offsets[3] = DRElement.CreateDRElement(fbb, 4,fbb.CreateString("Item_Bell铃铛"),60013,10004,11004,12004,0,0,110,0,fbb.CreateString("BellElement"),fbb.CreateString("Finder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[4] = DRElement.CreateDRElement(fbb, 5,fbb.CreateString("Item_WoodenBox2木箱"),60014,10005,11005,12005,6,0,0,1,fbb.CreateString("EliminateElement"),fbb.CreateString("WoodenBoxFinder"),-1,0,true,true,false,true,false,true,2,1);
            offsets[5] = DRElement.CreateDRElement(fbb, 6,fbb.CreateString("Item_WoodenBox1木箱"),60015,10006,11006,12006,0,0,0,1,fbb.CreateString("EliminateElement"),fbb.CreateString("WoodenBoxFinder"),-1,0,true,true,false,true,false,true,1,1);
            offsets[6] = DRElement.CreateDRElement(fbb, 7,fbb.CreateString("果子"),60022,10007,11007,12007,0,0,0,3,fbb.CreateString("AppleElement"),fbb.CreateString("Finder"),-1,0,true,true,false,false,false,false,3,1);
            offsets[7] = DRElement.CreateDRElement(fbb, 8,fbb.CreateString("小人"),60023,10008,11008,12008,0,0,0,3,fbb.CreateString("AppleElement"),fbb.CreateString("Finder"),-1,0,true,true,false,false,false,false,-100,1);
            offsets[8] = DRElement.CreateDRElement(fbb, 9,fbb.CreateString("摘果子_藤"),60024,10009,11009,12009,0,0,0,3,fbb.CreateString("AppleElement"),fbb.CreateString("Finder"),-1,0,true,true,false,false,false,false,-100,1);
            offsets[9] = DRElement.CreateDRElement(fbb, 10,fbb.CreateString("加步数"),60028,10010,11010,12010,0,0,0,5,fbb.CreateString("AddStepElement"),fbb.CreateString("Finder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[10] = DRElement.CreateDRElement(fbb, 11,fbb.CreateString("幽灵"),60030,10011,11011,12011,0,0,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[11] = DRElement.CreateDRElement(fbb, 12,fbb.CreateString("炸弹"),60032,10012,11012,12012,0,0,0,7,fbb.CreateString("BombElement"),fbb.CreateString("Finder"),-1,1,false,true,true,false,false,false,1,2);
            offsets[12] = DRElement.CreateDRElement(fbb, 13,fbb.CreateString("清屏"),60034,10013,11013,12013,0,35,0,8,fbb.CreateString("ClearScreenElement"),fbb.CreateString("Finder"),-1,1,false,true,true,false,false,false,1,1);
            offsets[13] = DRElement.CreateDRElement(fbb, 14,fbb.CreateString("幽灵"),60030,10014,11014,12014,0,0,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[14] = DRElement.CreateDRElement(fbb, 15,fbb.CreateString("幽灵"),60030,10015,11015,12015,0,1,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[15] = DRElement.CreateDRElement(fbb, 16,fbb.CreateString("幽灵"),60030,10016,11016,12016,0,2,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[16] = DRElement.CreateDRElement(fbb, 17,fbb.CreateString("幽灵"),60030,10017,11017,12017,0,3,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[17] = DRElement.CreateDRElement(fbb, 18,fbb.CreateString("幽灵"),60030,10018,11018,12018,0,4,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[18] = DRElement.CreateDRElement(fbb, 19,fbb.CreateString("幽灵"),60030,10019,11019,12019,0,5,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[19] = DRElement.CreateDRElement(fbb, 20,fbb.CreateString("幽灵"),60030,10020,11020,12020,0,6,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[20] = DRElement.CreateDRElement(fbb, 21,fbb.CreateString("消行"),-1,10021,11021,12021,0,0,0,-1,fbb.CreateString("BellElement"),fbb.CreateString("Finder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[21] = DRElement.CreateDRElement(fbb, 22,fbb.CreateString("小鹰"),60045,10022,11022,12022,0,0,0,0,fbb.CreateString("BellElement"),fbb.CreateString("Finder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[22] = DRElement.CreateDRElement(fbb, 23,fbb.CreateString("钥匙"),60049,10023,11023,12023,0,0,110,9,fbb.CreateString("KeyElement"),fbb.CreateString("Finder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[23] = DRElement.CreateDRElement(fbb, 24,fbb.CreateString("放大镜"),60050,10024,11024,12024,0,0,110,10,fbb.CreateString("MagnifierElement"),fbb.CreateString("Finder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[24] = DRElement.CreateDRElement(fbb, 25,fbb.CreateString("王子"),60052,10041,10041,10041,0,0,0,3,fbb.CreateString("AppleElement"),fbb.CreateString("Finder"),-1,0,true,true,false,false,false,false,-100,1);
            offsets[25] = DRElement.CreateDRElement(fbb, 26,fbb.CreateString("玫瑰花"),60055,10032,10032,10032,0,0,0,0,fbb.CreateString("BellElement"),fbb.CreateString("Finder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[26] = DRElement.CreateDRElement(fbb, 27,fbb.CreateString("幽灵动画"),60056,10011,11011,12011,0,0,0,6,fbb.CreateString("GhostElement"),fbb.CreateString("GhostFinder"),-2,0,true,true,false,false,false,false,1,3);
            offsets[27] = DRElement.CreateDRElement(fbb, 31,fbb.CreateString("糖纸"),60060,10038,10038,10038,0,83,0,0,fbb.CreateString("RainbowCandyBoxElement"),fbb.CreateString("Finder"),-1,0,true,true,false,true,false,true,1,1);
            offsets[28] = DRElement.CreateDRElement(fbb, 32,fbb.CreateString("彩虹糖"),60061,10039,10039,10039,0,0,0,0,fbb.CreateString("RainbowCandyElement"),fbb.CreateString("RainbowCandyFinder"),-1,0,true,true,false,false,false,false,1,1);
            offsets[29] = DRElement.CreateDRElement(fbb, 33,fbb.CreateString("石块"),60063,10040,10040,10040,0,0,0,0,fbb.CreateString("StoneElement"),fbb.CreateString("Finder"),-1,0,true,false,false,false,true,false,-100,1);
            offsets[30] = DRElement.CreateDRElement(fbb, 34,fbb.CreateString("睡美人"),60052,10033,10033,10033,0,0,0,3,fbb.CreateString("AppleElement"),fbb.CreateString("Finder"),-1,0,true,true,false,false,false,false,1,1);
            offsets[31] = DRElement.CreateDRElement(fbb, 35,fbb.CreateString("染色瓶"),60064,10043,10043,10043,0,0,0,13,fbb.CreateString("DyedBottleElement"),fbb.CreateString("DyedBottleFinder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[32] = DRElement.CreateDRElement(fbb, 36,fbb.CreateString("吻"),60065,10033,10033,10033,0,0,0,0,fbb.CreateString("BellElement"),fbb.CreateString("Finder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[33] = DRElement.CreateDRElement(fbb, 37,fbb.CreateString("老鼠"),60066,10044,10044,10044,0,0,0,12,fbb.CreateString("SusliksElement"),fbb.CreateString("SusliksFinder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[34] = DRElement.CreateDRElement(fbb, 38,fbb.CreateString("老鼠"),60066,10044,10044,10044,0,0,0,12,fbb.CreateString("SusliksElement"),fbb.CreateString("SusliksFinder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[35] = DRElement.CreateDRElement(fbb, 39,fbb.CreateString("老鼠"),60066,10044,10044,10044,0,0,0,12,fbb.CreateString("SusliksElement"),fbb.CreateString("SusliksFinder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[36] = DRElement.CreateDRElement(fbb, 40,fbb.CreateString("老鼠"),60066,10044,10044,10044,0,0,0,12,fbb.CreateString("SusliksElement"),fbb.CreateString("SusliksFinder"),-1,0,false,true,false,false,false,false,-1,1);
            offsets[37] = DRElement.CreateDRElement(fbb, 41,fbb.CreateString("染色瓶Lv2"),60064,10043,10043,10043,0,0,0,13,fbb.CreateString("DyedBottleExElement"),fbb.CreateString("Finder"),-1,1,false,true,false,false,false,false,1,1);
            offsets[38] = DRElement.CreateDRElement(fbb, 42,fbb.CreateString("啄木鸟"),60067,10054,10054,10054,0,0,0,14,fbb.CreateString("WoodPeckerElement"),fbb.CreateString("WoodPeckerFinder"),-2,0,true,true,false,false,false,false,1,3);

            VectorOffset dataOff = Table_Element.CreateDataVector(fbb, offsets);
            var configOff = Table_Element.CreateTable_Element(fbb, dataOff);
            Table_Element.FinishTable_ElementBuffer(fbb, configOff);
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