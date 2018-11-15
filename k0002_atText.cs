using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class k0002_atText : MonoBehaviour {
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;

    void Start () {
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        //k2_aaa:text.text = "・・・ "でTEXTのないよう変更。
        text.text = "k2_1_TextContentChange";
    }
    void Update() {
        //k2_aab1:スクリーン座標のテキスト幅   text.preferredWidth
        //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight
        /*
        Debug.Log("text幅::"+text.preferredWidth
            +"高さ::" +text.preferredHeight);
        */
    }
}
