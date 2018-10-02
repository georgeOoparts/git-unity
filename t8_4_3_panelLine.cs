using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//t8_panelLine:TEXTpanel内のwordPanelをただ一直線に並べる
//t8_panelLine_2:ターン性plusScreenWidth += rt1.sizeDelta.x;が差分
//t8_panelLine_3:TEXTPANEL1が短すぎるとバグが起こる。
//t8_panelLine_4_2:TEXTPANEL1が短すぎるとバグが起こる。p1,2,3でついに完成。後は解説文いれるだけ。
//t8_panelLine_4_3:TEXTPANEL1が短すぎるとバグが起こる。p7まで適応。
public class t8_4_3_panelLine : MonoBehaviour {
    float textLineWidth = 0;//前のパネルの幅、を入れる変数。
    float hanteiKaigyouWidth = 0;//ＴＥＸＴＰＡＮＥＬの幅を文字パネルの列が超えていないか判定する変数。
    float kakoTpanelWidth = 0;//ちょっと前のTEXTPANELの幅を入れる。ＴＥＸＴＰＡＮＥＬの幅が変化したかどうかを判定するとき使う

    float p2Start = 0;//panel2の開始位置
    float p3Start = 0;//panel3の開始位置
    float p4Start = 0;//panel4の開始位置
    float p5Start = 0;//panel5の開始位置
    float p6Start = 0;//panel6の開始位置
    float p7Start = 0;//panel7の開始位置

    int p2Kaigyou = 0;//panel2の行
    int p3Kaigyou = 0;//panel3の行
    int p4Kaigyou = 0;//panel4の行
    int p5Kaigyou = 0;//panel5の行
    int p6Kaigyou = 0;//panel6の行
    int p7Kaigyou = 0;//panel7の行

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
        //もし、一番最初。マウスボタンクリック。ＴＥＸＴＰＡＮＥＬの幅が変わったら下の処理を実行
        if (firstTime == true || Input.GetMouseButtonDown(0)|| kakoTpanelWidth != tpRt.sizeDelta.x) {
            //k4_aaa1:uiオブジェクトのスクリーン座標幅を得る

            p2Kaigyou = 0;//ｐ２Kaigyouをリセット　ターンが進むとこれがないと駄目
            p3Kaigyou = 0;//
            p4Kaigyou = 0;//p4Kaigyouをリセット　ターンが進むとこれがないと駄目
            p5Kaigyou = 0;//p5Kaigyouをリセット　ターンが進むとこれがないと駄目

            //ＰＡＮＥＬ２の開始位置のためにＰＮＥＬ１の幅を足す。
            textLineWidth += rt1.sizeDelta.x;
            p2Start = textLineWidth;
            //パネル２の行をチェックするために　代入
            hanteiKaigyouWidth += rt1.sizeDelta.x+rt2.sizeDelta.x;
            //panel2までの幅がＴＥＸＴＰＡＮＥＬの幅を超えたら
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = rt2.sizeDelta.x;
                p2Kaigyou = kaigyou; p2Start = textLineWidth;
            }
            //前のパネルが改行し、このパネルが改行しない場合下がいる。
            p2Kaigyou = kaigyou;

            //ＰＡＮＥＬ3の開始位置のためにＰＮＥＬ2の幅を足す。
            textLineWidth += rt2.sizeDelta.x;
            p3Start = textLineWidth;
            //パネル3の行をチェックするために　代入
            hanteiKaigyouWidth += rt3.sizeDelta.x;
            //panel3までの幅がＴＥＸＴＰＡＮＥＬの幅を超えたら
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = rt3.sizeDelta.x;
                p3Kaigyou = kaigyou; p3Start = textLineWidth;
            }
            //前のパネルが改行し、このパネルが改行しない場合下がいる。
            p3Kaigyou = kaigyou;

            //ＰＡＮＥＬ4の開始位置のためにＰＮＥＬ3の幅を足す。
            textLineWidth += rt3.sizeDelta.x;
            p4Start = textLineWidth;
            //パネル4の行をチェックするために　代入
            hanteiKaigyouWidth += rt4.sizeDelta.x;
            //panel4までの幅がＴＥＸＴＰＡＮＥＬの幅を超えたら
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = rt4.sizeDelta.x;
                p4Kaigyou = kaigyou; p4Start = textLineWidth;
               // Debug.Log(p4Kaigyou);
            }
            //前のパネルが改行し、このパネルが改行しない場合下がいる。
            p4Kaigyou = kaigyou;

            //ＰＡＮＥＬ5の開始位置のためにＰＮＥＬ4の幅を足す。
            textLineWidth += rt4.sizeDelta.x;
            p5Start = textLineWidth;
            //パネル4の行をチェックするために　代入
            hanteiKaigyouWidth += rt5.sizeDelta.x;
            //panel4までの幅がＴＥＸＴＰＡＮＥＬの幅を超えたら
            if (hanteiKaigyouWidth > tpRt.sizeDelta.x) {
                kaigyou++; textLineWidth = 0; hanteiKaigyouWidth = rt5.sizeDelta.x;
                p5Kaigyou = kaigyou; p5Start = textLineWidth;
            }
            //前のパネルが改行し、このパネルが改行しない場合下がいる。
            p5Kaigyou = kaigyou;
            //エラーチェックのための出力
            //Debug.Log(tpRt.sizeDelta.x + ":::" + hanteiKaigyouWidth);

            textLineWidth = 0;//最後にこれらの値をリセットする。
            hanteiKaigyouWidth = 0;
            kaigyou = 0;

            kakoTpanelWidth = tpRt.sizeDelta.x;//
        }
        firstTime = false;

        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)

        rt1.anchoredPosition = new Vector2(0, 0);//ＰＡＮＥＬ１をＴＥＸＴＰＮＥＬの左上へ置く。

        //パネル２の開始位置を決める。ｙ軸は下方向マイナスである事に注意 
        rt2.anchoredPosition= new Vector2(p2Start, -p2Kaigyou * rt1.sizeDelta.y);


        rt3.anchoredPosition= new Vector2(p3Start, -p3Kaigyou * rt1.sizeDelta.y);

        //Debug.Log(p4Kaigyou);
        //パネル4の開始位置を決める。ｙ軸は下方向マイナスである事に注意
        rt4.anchoredPosition = new Vector2(p4Start, -p4Kaigyou * rt1.sizeDelta.y);

        //Debug.Log(p5Kaigyou);
        //パネル5の開始位置を決める。ｙ軸は下方向マイナスである事に注意
        rt5.anchoredPosition = new Vector2(p5Start, -p5Kaigyou * rt1.sizeDelta.y);



    }
}
