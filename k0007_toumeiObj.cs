using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class k0007_toumeiObj : MonoBehaviour {
    // Use this for initialization
    void Start () {
        //k7_a:オブジェを存在するけど見えなくする。
        this.gameObject.GetComponent<Image>().enabled = false;
        //k7_b:オブジェを見えるようにするよ。
        this.gameObject.GetComponent<Image>().enabled = true;
    }
}
/*
    //k7オブジェクトを見えたり見えなくしたりする

    //k7_1:Imageコンポーネントを使う
    using UnityEngine.UI;

    //k7_1_1:オブジェを存在するけど見えなくする。
    this.gameObject.GetComponent<Image>().enabled = false;

    //k7_1_2:オブジェを見えるようにするよ。
    this.gameObject.GetComponent<Image>().enabled = true;
     
  */
