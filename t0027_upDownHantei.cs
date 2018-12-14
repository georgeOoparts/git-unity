using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0027_upDownHantei : MonoBehaviour {
    //スワイプの距離を入れるために使う変数。
    Vector3 firstPos;
    //上下判定で使う変数
    int upDown = 0;

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)) {
            upDown=upDownHantei();
            Debug.Log(upDown);
        }
    }
    
    //マウス入力upは1、downは2,どちらでもないは0を返す。
    int upDownHantei() {
        Vector3 diff = Input.mousePosition - firstPos;
        if (diff.y > 0) {
            //Debug.Log("up");
            return (1);
        } else if (diff.y < 0) {
            //Debug.Log("down");
            return (2);
        } else return (0);
    }
}
