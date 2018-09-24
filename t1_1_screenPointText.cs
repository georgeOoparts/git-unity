using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//t1_1_screenPointText
//text ui にアタッチする。マウスのスクリーンポイントをUIのtextに表示
public class t1_1_screenPointText : MonoBehaviour {
    Text text;
    // Use this for initialization
    void Start () {
        text = this.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "screen:: " + Input.mousePosition.ToString();
    }
}
