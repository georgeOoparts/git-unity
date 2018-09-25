using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class k7_toumeiObj : MonoBehaviour {
    // Use this for initialization
    void Start () {
        //k7_a:オブジェを存在するけど見えなくする。
        this.gameObject.GetComponent<Image>().enabled = false;
        //k7_b:オブジェを見えるようにするよ。
        this.gameObject.GetComponent<Image>().enabled = true;
    }
}
