using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//t8_panelLine:TEXTpanel内のwordPanelをただ一直線に並べる
//t8_panelLine_2:ターン性plusScreenWidth += rt1.sizeDelta.x;が差分
//t8_panelLine_3:TEXTPANEL1が短すぎるとバグが起こる。
public class t8_4_2_panelLine : MonoBehaviour {
    float textLineWidth = 0;//前のパネルの幅、を入れる変数。
    float hanteiKaigyouWidth = 0;//ＴＥＸＴＰＡＮＥＬの幅を文字パネルの列が超えていないか判定する変数。

    float p2Start = 0;//panel2の開始位置
    float p3Start = 0;//panel3の開始位置

    int p2Kaigyou = 0;//panel2の行
    int p3Kaigyou = 0;//panel3の行

    int kaigyou = 0;//縦への改行を入れる変数。

    bool firstTime = true;//アップデートメソッドの中で初めてかどうかチェックする変数。

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
    //panelの幅調整、テキストの幅調整のプログラムより、後にこのプログラムを実行するため、
    //LateUpdateで実行。
    void LateUpdate() {
        if (firstTime == true || Input.GetMouseButtonDown(0)) {
            //k4_aaa1:uiオブジェクトのスクリーン座標幅を得る
            //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)

            p2Kaigyou = 0;//ｐ２Kaigyouをリセット　ターンが進むとこれがないと駄目

            textLineWidth += rt1.sizeDelta.x;//ＰＡＮＥＬ２の開始位置のためにＰＮＥＬ１の幅を足す。
            p2Start = textLineWidth;

            hanteiKaigyouWidth += rt1.sizeDelta.x+rt2.sizeDelta.x;//パネル２の行をチェックするために　代入
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = rt2.sizeDelta.x;
                p2Kaigyou = kaigyou; p2Start = textLineWidth;
            }
            //Debug.Log(rt1.sizeDelta.x);

            
            textLineWidth += rt2.sizeDelta.x;
            hanteiKaigyouWidth += rt3.sizeDelta.x;
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = rt3.sizeDelta.x;
            }

            rt3.anchoredPosition 
                = new Vector2(textLineWidth, -kaigyou * rt1.sizeDelta.y);

            //エラーチェックのための出力
            Debug.Log(tpRt.sizeDelta.x + ":::" + hanteiKaigyouWidth);

            textLineWidth = 0;//最後にこれらの値をリセットする。
            hanteiKaigyouWidth = 0;
            kaigyou = 0;
        }
        firstTime = false;
        rt1.anchoredPosition = new Vector2(0, 0);//ＰＡＮＥＬ１をＴＥＸＴＰＮＥＬの左上へ置く。

        rt2.anchoredPosition//パネル２の開始位置を決める。ｙ軸は下方向マイナスである事に注意 
                = new Vector2(p2Start, -p2Kaigyou * rt1.sizeDelta.y);

    }
}
