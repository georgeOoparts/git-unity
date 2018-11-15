using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//textオブジェにアタッチ。テキストの長さに合わせてテキスト幅を広げる
public class t0002_textSizeSet: MonoBehaviour {
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    RectTransform rt;
    // Use this for initialization
    void Start () {
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt = this.gameObject.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        //textオブジェクトのサイズを文字に会わせる 
        //k2_aab1:スクリーン座標のテキスト幅   text.preferredWidth
        //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight
        //k4_aab:uiの幅、高さをスクリーン値で変形させる
        rt.sizeDelta= new Vector2(text.preferredWidth, text.preferredHeight);
    }
}
