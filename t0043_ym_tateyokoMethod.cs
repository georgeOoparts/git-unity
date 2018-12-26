using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0043_ym_tateyokoMethod : MonoBehaviour {
    //縦横スワイプをを判定するメソッド

    //スワイプの距離を入れるために使う変数。
    Vector3 firstPos;
    

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)) {
           
            Debug.Log(tateYokoHantei());
        }
    }

    //縦横スワイプをを判定するメソッド
    int tateYokoHantei() {
        Vector3 diff = Input.mousePosition - firstPos;
        if (diff.x < 0) diff.x=diff.x * -1;
        if (diff.y < 0) diff.y = diff.y* -1;

        if (diff.x > diff.y) {
            //横移動の方が大きければ１を返す
            return (1);
        } else {
            //縦移動の方が大きいか同じならば２を返す
            return (2);
        }
    }
}
