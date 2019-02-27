using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カード情報
/// </summary>
public struct cardInfo {
    public string name;         // ユニット名
    public string cran;         // クラン
    public string race;         // 種族
    public enum unitType        // ユニット種類
    {
        trigger,
        normal,
    }
    public enum skillIcon       // スキルアイコン
    {
        boost,
        intercept,
        twinDrive,
    }
    public int grade;           // グレード
    public int power;           // パワー
    public int shield;          // シールド
    public int critical;        // クリティカル
    
}

/// <summary>
/// カード情報クラス
/// </summary>
public class CardInfo :MonoBehaviour{
    private cardInfo info;
    public cardInfo getCardInfo {
        get { return info; }
    }
}

