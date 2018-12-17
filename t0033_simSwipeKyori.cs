using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0033_simSwipeKyori : MonoBehaviour {
    Vector3 objectPos;
    Vector3 firstPos;

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            firstPos = Input.mousePosition;
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //フリックの感覚にする。下にフリックすると上へ移動
            Vector3 diff = firstPos - Input.mousePosition;

            Debug.Log("f::" + firstPos
                + "diff::" + diff.y
                );
        }
    }
    //タップしたy軸の距離をスクリーンポイントでdebuglog表示させるプログラム
    //float tupDistanseScreen() {

    //}
}

