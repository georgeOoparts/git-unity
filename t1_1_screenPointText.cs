using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//t1_1_screenPointText
//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class t1_1_screenPointText : MonoBehaviour {
    Text text;//どこかに書かれている。Textというクラスを扱うための変数を作成
    // Use this for initialization
    void Start () {
        //Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        //text.text = "・・・ "でTEXTのないよう変更。
        //Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        text.text = "screen:: " + Input.mousePosition.ToString();
    }
}
