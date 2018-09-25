using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//テキストを子にもつ、textPanelのサイズを　子のＴＥＸＴにばっちり合わせる。
//このオブジェのアンカーをストレッチにするとうまく動かない。
public class t6_panelSizeSet : MonoBehaviour {
    GameObject kodomoObj;
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text kodomoText;
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform Rt;
    public float yohaku = 10;
    // Use this for initialization
    void Start() {
        //
        kodomoObj = this.gameObject.transform.GetChild(0).gameObject;
        kodomoText = kodomoObj.GetComponent<Text>();
        Rt = this.gameObject.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update() {
        //アンカーがストレッチ以外ならスクリーン座標の値でパネルの幅、高さを
        //指定できる。
        Rt.sizeDelta
            = new Vector2(kodomoText.preferredWidth + yohaku
            , kodomoText.preferredHeight + yohaku);
        Debug.Log("textPanelSizeSize_org:::"+kodomoText.preferredWidth);
    }
}
