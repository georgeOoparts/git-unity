using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class t1_1_screenPointText : MonoBehaviour {
    //k2_1_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    // Use this for initialization
    void Start () {
        //k2_1_b:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        //k2_1_c:text.text = "・・・ "でTEXTのないよう変更。
        //k3_1_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        text.text = "screen:: " + Input.mousePosition.ToString();
    }
}
