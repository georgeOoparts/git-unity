using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class t8_panelLine : MonoBehaviour {
    public float plusScreenWidth=0;

    GameObject p1;
    GameObject p2;
    GameObject p3;
    GameObject p4;
    GameObject p5;
    GameObject p6;
    GameObject p7;

    RectTransform rt1;
    RectTransform rt2;
    RectTransform rt3;
    RectTransform rt4;
    RectTransform rt5;
    RectTransform rt6;
    RectTransform rt7;
    // Use this for initialization
    void Start () {
        p1 = GameObject.Find("wordPanel1");
        p2 = GameObject.Find("wordPanel2");
        p3 = GameObject.Find("wordPanel3");
        p4 = GameObject.Find("wordPanel4");
        p5 = GameObject.Find("wordPanel5");
        p6 = GameObject.Find("wordPanel6");
        p7 = GameObject.Find("wordPanel7");

        rt1 = p1.GetComponent<RectTransform>();
        rt2 = p2.GetComponent<RectTransform>();
        rt3 = p3.GetComponent<RectTransform>();
        rt4 = p4.GetComponent<RectTransform>();
        rt5 = p5.GetComponent<RectTransform>();
        rt6 = p6.GetComponent<RectTransform>();
        rt7 = p7.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("t8_panelLine");
        rt1.anchoredPosition = new Vector2(0, 0);
        plusScreenWidth =rt1.sizeDelta.x;
        rt2.anchoredPosition = new Vector2(plusScreenWidth, 0);
        plusScreenWidth = rt1.sizeDelta.x+ rt2.sizeDelta.x;
        rt3.anchoredPosition = new Vector2(plusScreenWidth, 0);
        plusScreenWidth = rt1.sizeDelta.x + rt2.sizeDelta.x+ rt3.sizeDelta.x;
        rt4.anchoredPosition = new Vector2(plusScreenWidth, 0);
        plusScreenWidth = rt1.sizeDelta.x + rt2.sizeDelta.x + rt3.sizeDelta.x
            + rt4.sizeDelta.x;
        rt5.anchoredPosition = new Vector2(plusScreenWidth, 0);
        plusScreenWidth = rt1.sizeDelta.x + rt2.sizeDelta.x + rt3.sizeDelta.x
            + rt4.sizeDelta.x+ rt5.sizeDelta.x;
        rt6.anchoredPosition = new Vector2(plusScreenWidth, 0);
        plusScreenWidth = rt1.sizeDelta.x + rt2.sizeDelta.x + rt3.sizeDelta.x
            + rt4.sizeDelta.x + rt5.sizeDelta.x+ rt6.sizeDelta.x;
        rt7.anchoredPosition = new Vector2(plusScreenWidth, 0);
    }
}
