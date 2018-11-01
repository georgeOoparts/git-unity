using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class t10_rightTopX : MonoBehaviour {
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    int xPosition;
    GameObject oyaPanel;
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform RtOya;
    // Use this for initialization
    void Start() {
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();

        //k8_a:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
        oyaPanel = this.gameObject.transform.parent.gameObject;
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        RtOya = oyaPanel.GetComponent<RectTransform>();
    }

    void Update() {
        //k10_kataHenkan
        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        xPosition = (int)RtOya.anchoredPosition.x;
        // k4_aaa1:uiオブジェクトのスクリーン座標幅を得る
        //rt.sizeDelta.x
        xPosition += (int)RtOya.sizeDelta.x;

        // k2_aaa:text.text = "・・・ "でTEXTのないよう変更。
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        text.text = "RTX:: " + xPosition;
    }
}
