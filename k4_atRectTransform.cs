﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//textオブジェにアタッチ。テキストの長さに合わせてテキスト幅を広げる
public class k4_atRectTransform: MonoBehaviour {
    //k2_1_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    // Use this for initialization
    void Start () {
        //k2_1_b:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        //textオブジェクトのサイズを文字に会わせる 
        text.rectTransform.sizeDelta
            = new Vector2(text.preferredWidth, text.preferredHeight);
    }
}
