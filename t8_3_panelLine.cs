using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//t8_panelLine:TEXTpanel内のwordPanelをただ一直線に並べる
//t8_panelLine_2:ターン性plusScreenWidth += rt1.sizeDelta.x;が差分
//t8_panelLine_3:改行を追加　未完
public class t8_3_panelLine : MonoBehaviour {
    float textLineWidth = 0;
    float hanteiKaigyouWidth = 0;

    int kaigyou = 0;

    bool firstTime = true;

    GameObject p1;
    GameObject p2;
    GameObject p3;
    GameObject p4;
    GameObject p5;
    GameObject p6;
    GameObject p7;

    GameObject tPanel;
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt1;
    RectTransform rt2;
    RectTransform rt3;
    RectTransform rt4;
    RectTransform rt5;
    RectTransform rt6;
    RectTransform rt7;

    RectTransform tpRt;
    // Use this for initialization
    void Start() {
        p1 = GameObject.Find("wordPanel1");
        p2 = GameObject.Find("wordPanel2");
        p3 = GameObject.Find("wordPanel3");
        p4 = GameObject.Find("wordPanel4");
        p5 = GameObject.Find("wordPanel5");
        p6 = GameObject.Find("wordPanel6");
        p7 = GameObject.Find("wordPanel7");

        tPanel = GameObject.Find("textPanel");
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt1 = p1.GetComponent<RectTransform>();
        rt2 = p2.GetComponent<RectTransform>();
        rt3 = p3.GetComponent<RectTransform>();
        rt4 = p4.GetComponent<RectTransform>();
        rt5 = p5.GetComponent<RectTransform>();
        rt6 = p6.GetComponent<RectTransform>();
        rt7 = p7.GetComponent<RectTransform>();

        tpRt =tPanel.GetComponent<RectTransform>();
    }

    void LateUpdate() {
        if (firstTime == true || Input.GetMouseButtonDown(0)) {
            //k4_aaa1:uiオブジェクトのスクリーン座標幅を得る
            //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
            rt1.anchoredPosition = new Vector2(0,0);
            textLineWidth += rt1.sizeDelta.x;
            hanteiKaigyouWidth += rt1.sizeDelta.x+ rt2.sizeDelta.x;
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = 0;
            }
            //Debug.Log(rt1.sizeDelta.x);

            rt2.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);
            textLineWidth += rt2.sizeDelta.x;
            hanteiKaigyouWidth += rt2.sizeDelta.x+rt3.sizeDelta.x;
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = 0;
            }

            rt3.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);
            textLineWidth += rt3.sizeDelta.x;
            if (textLineWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0;
            }

            rt4.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);
            textLineWidth += rt4.sizeDelta.x;
            if (textLineWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0;
            }

            rt5.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);
            textLineWidth += rt5.sizeDelta.x;
            if (textLineWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0;
            }

            rt6.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);
            textLineWidth += rt6.sizeDelta.x;
            if (textLineWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0;
            }

            rt7.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);
            textLineWidth = 0;
            kaigyou = 0;
        }
        firstTime = false;
    }
}
