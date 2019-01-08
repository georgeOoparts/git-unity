using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class k0002_atText : MonoBehaviour {
}
/*
    k2::Text回り

    k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    -----------------
    k2_1_1:Textをこのオブジェクトで使うためのおまじない
    text = this.gameObject.GetComponent<Text>();
    -----------------
    k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
    text.text = "k2_1_TextContentChange";
    ------------------
    k2_1_1_2:スクリーン座標のテキスト幅   text.preferredWidth
    k2_1_1_3:スクリーン座標のテキスト高さ text.preferredHeight
*/
