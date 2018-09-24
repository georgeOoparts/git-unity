using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//textオブジェにアタッチ。
//uiをrectTransformで移動。サイズ変更。
public class t4_1_uiMoveSizeChange : MonoBehaviour {
    //k2_1_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    RectTransform rtText;

    // Use this for initialization
    void Start () {
        //k2_1_b:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        rtText = text.rectTransform;
    }
	
	// Update is called once per frame
	void Update () {
        //textオブジェクトのサイズを文字に会わせる 
        rtText.sizeDelta
            = new Vector2(text.preferredWidth, text.preferredHeight);
    }
}
