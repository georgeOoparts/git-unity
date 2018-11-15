using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//textオブジェにアタッチ。テキストの長さに合わせてテキスト幅を広げる
public class k0004_atRectTransform: MonoBehaviour {
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;
    // Use this for initialization
    void Start () {
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt = this.gameObject.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        //k4_aaa1:uiオブジェクトのスクリーン座標幅を得る
        //rt.sizeDelta.x
        //k4_aaa2:uiオブジェクトのスクリーン座標高さを得る
        //rt.sizeDelta.y

        //k4_aab:uiの幅、高さをスクリーン値で変形させる
        //rt.sizeDelta = new Vector2(100,100);

        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        //rt.anchoredPosition = new Vector2(190, -145);
        //k4_aac2:uiをワールド値で移動
        rt.position = new Vector2(0,0);
    }
}
