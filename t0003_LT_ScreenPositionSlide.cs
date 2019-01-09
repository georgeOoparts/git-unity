using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class t0003_LT_ScreenPositionSlide : MonoBehaviour {
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;
	// Use this for initialization
	void Start () {
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt = this.gameObject.GetComponent<RectTransform>();
	}
	// Update is called once per frame
	void Update () {
        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        rt.anchoredPosition =new Vector2(0,0);
    }
}
