using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class t8_panelLine : MonoBehaviour {
    GameObject p1;
    //GameObject p2;
    //GameObject p3;
    //GameObject p4;
    //GameObject p5;
    //GameObject p6;
    //GameObject p7;

    RectTransform rt1;
    //RectTransform rt2;
    //RectTransform rt3;
    //RectTransform rt4;
    //RectTransform rt5;
    //RectTransform rt6;
    //RectTransform rt7;
    // Use this for initialization
    void Start () {
        p1 = GameObject.Find("wordPanel1");
        //p2 = GameObject.Find("worldPanel2");
        //p3 = GameObject.Find("worldPanel3");
        //p4 = GameObject.Find("worldPanel4");
        //p5 = GameObject.Find("worldPanel5");
        //p6 = GameObject.Find("worldPanel6");
        //p7 = GameObject.Find("worldPanel7");

        rt1 = p1.GetComponent<RectTransform>();
        //rt2 = p2.GetComponent<RectTransform>();
        //rt3 = p3.GetComponent<RectTransform>();
        //rt4 = p4.GetComponent<RectTransform>();
        //rt5 = p5.GetComponent<RectTransform>();
        //rt6 = p6.GetComponent<RectTransform>();
        //rt7 = p7.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("t8_panelLine");
        rt1.anchoredPosition = new Vector2(0, 0);
	}
}
