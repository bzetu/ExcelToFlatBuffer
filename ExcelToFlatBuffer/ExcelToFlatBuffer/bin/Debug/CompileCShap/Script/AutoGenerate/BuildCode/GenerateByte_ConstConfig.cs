using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_ConstConfig : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_ConstConfig.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRConstConfig>[] offsets = new Offset<DRConstConfig>[78];
   
            offsets[0] = DRConstConfig.CreateDRConstConfig(fbb, 1,fbb.CreateString("俄罗斯方块棋盘横格子数量"),fbb.CreateString("TETRIS_AREA_X_COUNT"),fbb.CreateString("9"));
            offsets[1] = DRConstConfig.CreateDRConstConfig(fbb, 2,fbb.CreateString("俄罗斯方块棋盘竖格子数量"),fbb.CreateString("TETRIS_AREA_Y_COUNT"),fbb.CreateString("16"));
            offsets[2] = DRConstConfig.CreateDRConstConfig(fbb, 3,fbb.CreateString("俄罗斯方块棋盘副区域横格子数量"),fbb.CreateString("TETRIS_VICE_AREA_X_COUNT"),fbb.CreateString("2"));
            offsets[3] = DRConstConfig.CreateDRConstConfig(fbb, 4,fbb.CreateString("方块正常下落速度(单位秒,如果≤0,那么不下落)"),fbb.CreateString("NormalFallingSpeed"),fbb.CreateString("-1"));
            offsets[4] = DRConstConfig.CreateDRConstConfig(fbb, 5,fbb.CreateString("方块加速下落速度(单位秒)"),fbb.CreateString("AccelerateFallingSpeed"),fbb.CreateString("0.1"));
            offsets[5] = DRConstConfig.CreateDRConstConfig(fbb, 6,fbb.CreateString("方块自由落体下落速度(单位秒)"),fbb.CreateString("FreeFallingSpeed"),fbb.CreateString("0.1"));
            offsets[6] = DRConstConfig.CreateDRConstConfig(fbb, 7,fbb.CreateString("方块消除抖动时间(毫秒)"),fbb.CreateString("BLOCK_DESTROY_SHAKE_TIME"),fbb.CreateString("800"));
            offsets[7] = DRConstConfig.CreateDRConstConfig(fbb, 8,fbb.CreateString("幽灵配置（0-出生后多少个回合不消失生成下一个,1-死后多少回合可以生成下一个,2-幽灵存在的最大数量,3-开局时多少回合生成幽灵,4-出生倒计时回合数,5-关卡生成的幽灵id）"),fbb.CreateString("GHOST_PARAM"),fbb.CreateString("10|3|2|3|3|14"));
            offsets[8] = DRConstConfig.CreateDRConstConfig(fbb, 9,fbb.CreateString("是否开启新手引导"),fbb.CreateString("IsOpenNewbieGuide"),fbb.CreateString("TRUE"));
            offsets[9] = DRConstConfig.CreateDRConstConfig(fbb, 10,fbb.CreateString("方块消除前预警特效ID"),fbb.CreateString("BlockWarningEffectID"),fbb.CreateString("28"));
            offsets[10] = DRConstConfig.CreateDRConstConfig(fbb, 11,fbb.CreateString("方块消除特效ID"),fbb.CreateString("BlockDestroyEffectID"),fbb.CreateString("27"));
            offsets[11] = DRConstConfig.CreateDRConstConfig(fbb, 12,fbb.CreateString("消行粒子汇聚特效ID(消除n行对应的特效ID)"),fbb.CreateString("ParticleComeTogetherEffectID"),fbb.CreateString("0|56|57|58"));
            offsets[12] = DRConstConfig.CreateDRConstConfig(fbb, 13,fbb.CreateString("流星雨初始积分"),fbb.CreateString("ShootingStarScoreSum"),fbb.CreateString("2000"));
            offsets[13] = DRConstConfig.CreateDRConstConfig(fbb, 14,fbb.CreateString("流星雨扣减积分"),fbb.CreateString("ShootingStarScoreDeduction"),fbb.CreateString("100"));
            offsets[14] = DRConstConfig.CreateDRConstConfig(fbb, 15,fbb.CreateString("流星雨初始金币"),fbb.CreateString("ShootingStarCoinSum"),fbb.CreateString("100"));
            offsets[15] = DRConstConfig.CreateDRConstConfig(fbb, 16,fbb.CreateString("流星雨扣减金币"),fbb.CreateString("ShootingStarCoinDeduction"),fbb.CreateString("10"));
            offsets[16] = DRConstConfig.CreateDRConstConfig(fbb, 17,fbb.CreateString("消行随机产生粒子点距离道具生成点格子数"),fbb.CreateString("ParticlePropDistance"),fbb.CreateString("2"));
            offsets[17] = DRConstConfig.CreateDRConstConfig(fbb, 18,fbb.CreateString("消两行产生粒子数量"),fbb.CreateString("RemoveTwoLineParticleSum"),fbb.CreateString("3"));
            offsets[18] = DRConstConfig.CreateDRConstConfig(fbb, 19,fbb.CreateString("消三行产生粒子数量"),fbb.CreateString("RemoveThreeLineParticleSum"),fbb.CreateString("5"));
            offsets[19] = DRConstConfig.CreateDRConstConfig(fbb, 20,fbb.CreateString("消四行及以上产生粒子数量"),fbb.CreateString("RemoveFourOrMoreLineParticleSum"),fbb.CreateString("8"));
            offsets[20] = DRConstConfig.CreateDRConstConfig(fbb, 21,fbb.CreateString("一星UI位置"),fbb.CreateString("OneStarUIRatio"),fbb.CreateString("0.285"));
            offsets[21] = DRConstConfig.CreateDRConstConfig(fbb, 22,fbb.CreateString("二星UI位置"),fbb.CreateString("TwoStarUIRatio"),fbb.CreateString("0.285"));
            offsets[22] = DRConstConfig.CreateDRConstConfig(fbb, 23,fbb.CreateString("三星UI位置"),fbb.CreateString("ThreeStarUIRatio"),fbb.CreateString("0.35"));
            offsets[23] = DRConstConfig.CreateDRConstConfig(fbb, 24,fbb.CreateString("四星UI位置"),fbb.CreateString("FourStarUIRatio"),fbb.CreateString("0.08"));
            offsets[24] = DRConstConfig.CreateDRConstConfig(fbb, 25,fbb.CreateString("方块跳字名称"),fbb.CreateString("BlockScoreUIWightItemName"),fbb.CreateString("JumpWordForm"));
            offsets[25] = DRConstConfig.CreateDRConstConfig(fbb, 26,fbb.CreateString("元素跳字名称"),fbb.CreateString("ElementScoreUIWightItemName"),fbb.CreateString("JumpWordForm_Special"));
            offsets[26] = DRConstConfig.CreateDRConstConfig(fbb, 27,fbb.CreateString("金币跳字名称"),fbb.CreateString("CoinScoreUIWightItemName"),fbb.CreateString("JumpWordForm_Gold"));
            offsets[27] = DRConstConfig.CreateDRConstConfig(fbb, 28,fbb.CreateString("一星金币衰减系数"),fbb.CreateString("GradeOneCoinRatio"),fbb.CreateString("0.3"));
            offsets[28] = DRConstConfig.CreateDRConstConfig(fbb, 29,fbb.CreateString("二星金币衰减系数"),fbb.CreateString("GradeTwoCoinRatio"),fbb.CreateString("0.2"));
            offsets[29] = DRConstConfig.CreateDRConstConfig(fbb, 30,fbb.CreateString("三星金币衰减系数"),fbb.CreateString("GradeThreeCoinRatio"),fbb.CreateString("0.1"));
            offsets[30] = DRConstConfig.CreateDRConstConfig(fbb, 31,fbb.CreateString("炸墙炸弹分数"),fbb.CreateString("WallBombScore"),fbb.CreateString("2000"));
            offsets[31] = DRConstConfig.CreateDRConstConfig(fbb, 32,fbb.CreateString("连消积分系数"),fbb.CreateString("ComboScoreRatio"),fbb.CreateString("1"));
            offsets[32] = DRConstConfig.CreateDRConstConfig(fbb, 33,fbb.CreateString("第一次滑屏像素容错"),fbb.CreateString("SwipeToleranceInPixel4First"),fbb.CreateString("10"));
            offsets[33] = DRConstConfig.CreateDRConstConfig(fbb, 34,fbb.CreateString("常规滑屏像素容错"),fbb.CreateString("SwipeToleranceInPixel4General"),fbb.CreateString("100"));
            offsets[34] = DRConstConfig.CreateDRConstConfig(fbb, 35,fbb.CreateString("常规滑屏像素容错最小值"),fbb.CreateString("SwipeToleranceInPixel4GeneralMin"),fbb.CreateString("50"));
            offsets[35] = DRConstConfig.CreateDRConstConfig(fbb, 36,fbb.CreateString("常规滑屏像素容错最大值"),fbb.CreateString("SwipeToleranceInPixel4GeneralMax"),fbb.CreateString("200"));
            offsets[36] = DRConstConfig.CreateDRConstConfig(fbb, 37,fbb.CreateString("快速下滑像素容错"),fbb.CreateString("QuickDownToleranceInPixel"),fbb.CreateString("24"));
            offsets[37] = DRConstConfig.CreateDRConstConfig(fbb, 38,fbb.CreateString("快速上滑像素容错"),fbb.CreateString("QuickUpToleranceInPixel"),fbb.CreateString("24"));
            offsets[38] = DRConstConfig.CreateDRConstConfig(fbb, 39,fbb.CreateString("快速下滑有效时间"),fbb.CreateString("QuickDownEffectiveTime"),fbb.CreateString("0.24"));
            offsets[39] = DRConstConfig.CreateDRConstConfig(fbb, 40,fbb.CreateString("长点击所需时间"),fbb.CreateString("LongTapTime"),fbb.CreateString("0.16"));
            offsets[40] = DRConstConfig.CreateDRConstConfig(fbb, 41,fbb.CreateString("进入关卡消耗的体力值"),fbb.CreateString("HeartPerCost"),fbb.CreateString("5"));
            offsets[41] = DRConstConfig.CreateDRConstConfig(fbb, 42,fbb.CreateString("体力的上限值"),fbb.CreateString("MaxHeart"),fbb.CreateString("25"));
            offsets[42] = DRConstConfig.CreateDRConstConfig(fbb, 43,fbb.CreateString("同一个元素两次有效激活的时间间隔(单位毫秒)"),fbb.CreateString("ActiveElementInterval"),fbb.CreateString("2000"));
            offsets[43] = DRConstConfig.CreateDRConstConfig(fbb, 44,fbb.CreateString("每个染色瓶触发后染色方块的数量"),fbb.CreateString("StainingBottle"),fbb.CreateString("4"));
            offsets[44] = DRConstConfig.CreateDRConstConfig(fbb, 45,fbb.CreateString("方块反馈效果_一键下滑_动画时长"),fbb.CreateString("BlockFeedback_QuickDown_Duration"),fbb.CreateString("0.3"));
            offsets[45] = DRConstConfig.CreateDRConstConfig(fbb, 46,fbb.CreateString("方块反馈效果_一键下滑_动画启动延时"),fbb.CreateString("BlockFeedback_QuickDown_Delay"),fbb.CreateString("0"));
            offsets[46] = DRConstConfig.CreateDRConstConfig(fbb, 47,fbb.CreateString("方块反馈效果_一键下滑_震动幅度"),fbb.CreateString("BlockFeedback_QuickDown_Strength"),fbb.CreateString("0.2"));
            offsets[47] = DRConstConfig.CreateDRConstConfig(fbb, 48,fbb.CreateString("方块反馈效果_飞机击中_动画时长"),fbb.CreateString("BlockFeedback_PlaneKick_Duration"),fbb.CreateString("0.5"));
            offsets[48] = DRConstConfig.CreateDRConstConfig(fbb, 49,fbb.CreateString("方块反馈效果_飞机击中_动画启动延时"),fbb.CreateString("BlockFeedback_PlaneKick_Delay"),fbb.CreateString("0"));
            offsets[49] = DRConstConfig.CreateDRConstConfig(fbb, 50,fbb.CreateString("方块反馈效果_飞机击中_震动幅度"),fbb.CreateString("BlockFeedback_PlaneKick_Strength"),fbb.CreateString("0.4"));
            offsets[50] = DRConstConfig.CreateDRConstConfig(fbb, 51,fbb.CreateString("方块反馈效果_炸弹爆炸_动画时长"),fbb.CreateString("BlockFeedback_BombKick_Duration"),fbb.CreateString("0.5"));
            offsets[51] = DRConstConfig.CreateDRConstConfig(fbb, 52,fbb.CreateString("方块反馈效果_炸弹爆炸_震动幅度(5层)"),fbb.CreateString("BlockFeedback_BombKick_Strength"),fbb.CreateString("0.5|0.4|0.3|0.25|0.15"));
            offsets[52] = DRConstConfig.CreateDRConstConfig(fbb, 53,fbb.CreateString("方块反馈效果_炸弹爆炸_内层开始等待时间"),fbb.CreateString("BlockFeedback_BombKick_FirstDelay"),fbb.CreateString("0.05"));
            offsets[53] = DRConstConfig.CreateDRConstConfig(fbb, 54,fbb.CreateString("方块反馈效果_炸弹爆炸_每层延迟时间"),fbb.CreateString("BlockFeedback_BombKick_DelayInterval"),fbb.CreateString("0.1"));
            offsets[54] = DRConstConfig.CreateDRConstConfig(fbb, 55,fbb.CreateString("方块反馈效果_火箭触发_动画时长"),fbb.CreateString("BlockFeedback_RocketKick_Duration"),fbb.CreateString("0.8"));
            offsets[55] = DRConstConfig.CreateDRConstConfig(fbb, 56,fbb.CreateString("方块反馈效果_火箭触发_动画启动延时"),fbb.CreateString("BlockFeedback_RocketKick_Delay"),fbb.CreateString("0"));
            offsets[56] = DRConstConfig.CreateDRConstConfig(fbb, 57,fbb.CreateString("方块反馈效果_火箭触发_震动幅度"),fbb.CreateString("BlockFeedback_RocketKick_Strength"),fbb.CreateString("0.5"));
            offsets[57] = DRConstConfig.CreateDRConstConfig(fbb, 58,fbb.CreateString("方块与投影重叠时N毫秒后自动落定(如果为0或者负数,那么不会自动落定)"),fbb.CreateString("AssembleAutoFallingInterval"),fbb.CreateString("3000"));
            offsets[58] = DRConstConfig.CreateDRConstConfig(fbb, 59,fbb.CreateString("方块点亮效果_炸弹_开始点亮前_等待时间"),fbb.CreateString("BlockLight_Bomb_Appear_WaitTime"),fbb.CreateString("1"));
            offsets[59] = DRConstConfig.CreateDRConstConfig(fbb, 60,fbb.CreateString("方块点亮效果_炸弹_外层方块(第3层)的亮度[1最亮,0透明]"),fbb.CreateString("BlockLight_Bomb_OuterBlock_Alpha"),fbb.CreateString("0.2"));
            offsets[60] = DRConstConfig.CreateDRConstConfig(fbb, 61,fbb.CreateString("方块点亮效果_炸弹_层间_亮度增量[1最亮,0透明]"),fbb.CreateString("BlockLight_Bomb_Block_AlphaInterval"),fbb.CreateString("0.3"));
            offsets[61] = DRConstConfig.CreateDRConstConfig(fbb, 62,fbb.CreateString("方块点亮效果_炸弹_方块出现开始_到消失的时间"),fbb.CreateString("BlockLight_Bomb_InnerBlock_FadeTime"),fbb.CreateString("0.65"));
            offsets[62] = DRConstConfig.CreateDRConstConfig(fbb, 63,fbb.CreateString("方块点亮效果_炸弹_层间爆炸_间隔"),fbb.CreateString("BlockLight_Bomb_Block_Explore_Interval"),fbb.CreateString("0.03"));
            offsets[63] = DRConstConfig.CreateDRConstConfig(fbb, 64,fbb.CreateString("高级染色瓶触发后染色方块的数量"),fbb.CreateString("StainingBottleSenior"),fbb.CreateString("10"));
            offsets[64] = DRConstConfig.CreateDRConstConfig(fbb, 65,fbb.CreateString("睡美人动画播放时间"),fbb.CreateString("SleepingBeautyWaitForVictoryTime"),fbb.CreateString("11"));
            offsets[65] = DRConstConfig.CreateDRConstConfig(fbb, 66,fbb.CreateString("王子移动速度(每X秒移动1格)"),fbb.CreateString("PrinceMobileSpeed"),fbb.CreateString("0.5"));
            offsets[66] = DRConstConfig.CreateDRConstConfig(fbb, 67,fbb.CreateString("恢复一点体力所需时间"),fbb.CreateString("RecoverStaminaTime"),fbb.CreateString("360"));
            offsets[67] = DRConstConfig.CreateDRConstConfig(fbb, 68,fbb.CreateString("消除糖纸飞出彩虹糖的持续时间"),fbb.CreateString("RainCandyDurationTime"),fbb.CreateString("0.8"));
            offsets[68] = DRConstConfig.CreateDRConstConfig(fbb, 69,fbb.CreateString("幽灵数量模式下的首次生成回合"),fbb.CreateString("GhostByRound_FistRoundNum"),fbb.CreateString("1"));
            offsets[69] = DRConstConfig.CreateDRConstConfig(fbb, 70,fbb.CreateString("幽灵附着方块持续回合数"),fbb.CreateString("GhostState_Jump"),fbb.CreateString("3"));
            offsets[70] = DRConstConfig.CreateDRConstConfig(fbb, 71,fbb.CreateString("幽灵吃方块持续回合数"),fbb.CreateString("GhostState_Eat"),fbb.CreateString("3"));
            offsets[71] = DRConstConfig.CreateDRConstConfig(fbb, 72,fbb.CreateString("购买步数价格阶梯值"),fbb.CreateString("BuyStepPriceValue"),fbb.CreateString("10|20|30|40"));
            offsets[72] = DRConstConfig.CreateDRConstConfig(fbb, 73,fbb.CreateString("推屏延迟时间"),fbb.CreateString("ScreenForwardDelayTime"),fbb.CreateString("1"));
            offsets[73] = DRConstConfig.CreateDRConstConfig(fbb, 74,fbb.CreateString("本地数据存储时间间隔(秒)"),fbb.CreateString("LocalDataStorageInterval"),fbb.CreateString("60"));
            offsets[74] = DRConstConfig.CreateDRConstConfig(fbb, 75,fbb.CreateString("长按左右按钮时方块左右移动速度(毫秒)"),fbb.CreateString("TetrisBlockMovehHorizontalSpeed"),fbb.CreateString("100"));
            offsets[75] = DRConstConfig.CreateDRConstConfig(fbb, 76,fbb.CreateString("啄木鸟附着方块持续回合数"),fbb.CreateString("WoodPeckerFirstStateRoundNum"),fbb.CreateString("4"));
            offsets[76] = DRConstConfig.CreateDRConstConfig(fbb, 77,fbb.CreateString("俄罗斯方块经典玩法棋盘横格子数量"),fbb.CreateString("CLASSIC_TETRIS_AREA_X_COUNT"),fbb.CreateString("10"));
            offsets[77] = DRConstConfig.CreateDRConstConfig(fbb, 78,fbb.CreateString("俄罗斯方块经典玩法棋盘竖格子数量"),fbb.CreateString("CLASSIC_TETRIS_AREA_Y_COUNT"),fbb.CreateString("21"));

            VectorOffset dataOff = Table_ConstConfig.CreateDataVector(fbb, offsets);
            var configOff = Table_ConstConfig.CreateTable_ConstConfig(fbb, dataOff);
            Table_ConstConfig.FinishTable_ConstConfigBuffer(fbb, configOff);
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