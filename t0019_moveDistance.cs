using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//クリックした所からスワイプ先の距離を表示
//t20newSwipeと一緒に使うとうまくいかない

public class t0019_moveDistance : MonoBehaviour {
    Vector3 objectPos;
    Vector3 firstPos;
    void Start () {
        Debug.Log("move");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            //
            firstPos =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
           
            //フリックの感覚にする。下にフリックすると上へ移動
            Vector3 diff =
                firstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log("f::" + firstPos
                //+"now::"+ Camera.main.ScreenToWorldPoint(Input.mousePosition)
                + "diff::"+ diff.y
                );

        }
    }
}
