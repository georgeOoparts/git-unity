using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class u0002_worldPointText : MonoBehaviour {
    
    ////?
    Vector3 position;
    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    
    void Start() {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }

    void Update() {
        //k0003_1:Input.mousePositionでマウスのスクリーンポイントを
        position = Input.mousePosition;

        //k0004_1_1_a1:スクリーン座標＞ワールド座標
        //ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。
        position = Camera.main.ScreenToWorldPoint(position);

        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        //k0003_2:Input.mousePosition.ToString()でマウスのスクリーンポイントを
        //string形式で代入
        ////?
        text.text = "world :: " + position.ToString();
    }
}
