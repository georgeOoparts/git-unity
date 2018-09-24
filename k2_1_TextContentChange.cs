using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class k2_1_TextContentChange : MonoBehaviour {
    //k2_1_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;

    void Start () {
        //k2_1_b:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        //k2_1_c:text.text = "・・・ "でTEXTのないよう変更。
    }
    void Update() {
        text.text = "k2_1_TextContentChange";

        Debug.Log("text幅::"+text.preferredWidth+"高さ::"+text.preferredHeight);
    }
}
