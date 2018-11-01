using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class t13_leftBottomY : MonoBehaviour {
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    int yPosition;
    // Use this for initialization
    void Start () {
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        //Debug.Log("www");	
        
    }
	
	// Update is called once per frame
	void Update () {
        //k10_kataHenkan
        yPosition = (int)Input.mousePosition.y;
        // k2_aaa:text.text = "・・・ "でTEXTのないよう変更。
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        text.text = "LBY:: " + yPosition;
    }
}
