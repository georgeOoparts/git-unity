using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class t0011_rightTopY : MonoBehaviour {
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    int yPosition;
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
        yPosition = (int)RtOya.anchoredPosition.y;
        //k4_aaa2:uiオブジェクトのスクリーン座標高さを得る
        //rt.sizeDelta.y
        yPosition += (int)RtOya.sizeDelta.y;

        // k2_aaa:text.text = "・・・ "でTEXTのないよう変更。
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        text.text = "RTY:: " + yPosition;
    }
}
