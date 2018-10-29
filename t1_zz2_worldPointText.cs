using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t1_zz2_worldPointText : MonoBehaviour {
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Vector3 position;
    Text text;
    // Use this for initialization
    void Start () {
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        position = Input.mousePosition;
        //k3_zz2_a:スクリーン座標＞ワールド座標
        position = Camera.main.ScreenToWorldPoint(position);
        //k2_aaa:text.text = "・・・ "でTEXTのないよう変更。
        text.text = "world :: " + position.ToString();
	}
}
