using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class k0002_atText : MonoBehaviour {
}
/*
    k2_1_a1:どこかに書かれている。Textというクラスを扱うための変数を作成
   Text text;
   -----------------
   k2_1_a2:Textをこのオブジェクトで使うためのおまじない
   text = this.gameObject.GetComponent<Text>();
   -----------------
   k2_1_a3:text.text = "・・・ "でTEXTのないよう変更。
   text.text = "k2_1_TextContentChange";
   ------------------
   k2_1_a4:スクリーン座標のテキスト幅   text.preferredWidth
   k2_1_a5:スクリーン座標のテキスト高さ text.preferredHeight
   */
