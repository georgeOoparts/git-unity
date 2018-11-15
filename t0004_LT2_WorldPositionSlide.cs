using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t0004_LT2_WorldPositionSlide : MonoBehaviour {
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;
    //leftTopのテキストをインスペで当てはめる
    public GameObject ltText;
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text ltTx;
    // Use this for initialization
    void Start () {
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt = this.gameObject.GetComponent<RectTransform>();
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        ltTx = ltText.GetComponent<Text>();
    }
	// Update is called once per frame
	void Update () {
        //一番左上のltTextの高さだけ下にポジショニング
        
        //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight 
        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        rt.anchoredPosition = new Vector2(0,-ltTx.preferredHeight);
    }
}
