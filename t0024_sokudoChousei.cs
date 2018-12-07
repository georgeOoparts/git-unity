using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0024_sokudoChousei : MonoBehaviour {
    Vector3 objectPos;
    Vector3 firstPos;
    
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            firstPos = Input.mousePosition;
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //フリックの感覚にする。下にフリックすると上へ移動
            //あくまでスクリーンポイント
            Vector3 diff= firstPos - Input.mousePosition;
            //Camera.main.ScreenToWorldPoint(
            //firstPos - Input.mousePosition);
            //diff = Camera.main.ScreenToWorldPoint(diff);

            Debug.Log("f::" + firstPos
                //+"now::"+ Camera.main.ScreenToWorldPoint(Input.mousePosition)
                + "diff_x::" + diff.x
                + "diff_y::" + diff.y
                + "diff_z::" + diff.z
                );

        }
    }
}
