using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//textオブジェにアタッチ。テキストの長さに合わせてテキスト幅を広げる

public class u0003_textSizeSet : MonoBehaviour {
    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;

    //k4_1:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;

    void Start() {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        //k4_1_1:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt = this.gameObject.GetComponent<RectTransform>();
    }

    void Update() {
        //textオブジェクトのサイズを文字に会わせる 
        //k4_1_1_3:uiの幅、高さをスクリーン値で変形させる
        //k2_1_1_2:スクリーン座標のテキスト幅
        //k2_1_1_3:スクリーン座標のテキスト高さ
        rt.sizeDelta = new Vector2(text.preferredWidth, text.preferredHeight);
    }
}

