// Generated by the table tool compiler.  DO NOT EDIT!

package com.cyou.fusion.table.data;

import com.fasterxml.jackson.annotation.JsonProperty;

public class TableLevelTarget {

     @JsonProperty("#Id")
     private int m#Id;
     @JsonProperty("Desc")
     private int mDesc;
     @JsonProperty("ItemId:0")
     private int mItemId:0;
     @JsonProperty("ItemId:1")
     private int mItemId:1;
     @JsonProperty("ItemId:2")
     private int mItemId:2;
     @JsonProperty("Count:0")
     private int mCount:0;
     @JsonProperty("Count:1")
     private int mCount:1;
     @JsonProperty("Count:2")
     private int mCount:2;
     @JsonProperty("TreasureMapDataId")
     private int mTreasureMapDataId;
     @JsonProperty("CoinCount")
     private int mCoinCount;
     @JsonProperty("DiamondCount")
     private int mDiamondCount;
     @JsonProperty("StaminaCount")
     private int mStaminaCount;
     @JsonProperty("InfiniteStaminaTime")
     private int mInfiniteStaminaTime;


     //#关卡ID     
     public int get#Id(){return this.m#Id;}
     //描述(不读)     
     public int getDesc(){return this.mDesc;}
     //commonItemId     
     public int getItemId:0(){return this.mItemId:0;}
     //commonItemId     
     public int getItemId:1(){return this.mItemId:1;}
     //commonItemId     
     public int getItemId:2(){return this.mItemId:2;}
     //数量     
     public int getCount:0(){return this.mCount:0;}
     //数量     
     public int getCount:1(){return this.mCount:1;}
     //数量     
     public int getCount:2(){return this.mCount:2;}
     //掉落的藏宝图资源id     
     public int getTreasureMapDataId(){return this.mTreasureMapDataId;}
     //金币     
     public int getCoinCount(){return this.mCoinCount;}
     //钻石     
     public int getDiamondCount(){return this.mDiamondCount;}
     //体力     
     public int getStaminaCount(){return this.mStaminaCount;}
     //体力持续时间（分钟）     
     public int getInfiniteStaminaTime(){return this.mInfiniteStaminaTime;}


}