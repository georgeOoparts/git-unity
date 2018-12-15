using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//単純にスワイプでメインカメラ（アタッチしたオブジェ）を動かす。プログラム
public class t0030_simSwipe : MonoBehaviour {

    void Update() {
        flickControl();
    }
    Vector3 objectPos;
    Vector3 firstPos;
    
    private void flickControl() {
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            //最初のマウスの位置
            firstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //動かされるカメラの現在の位置
            objectPos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            //初めのマウスの位置と今のマウスの位置の差異
            Vector3 diff =
                firstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //初めのマウスの位置と今のマウスの位置の差異が0じゃなければ
            if (diff != Vector3.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diff.x = 0.0f;
                diff.z = 0.0f;
                //カメラの位置にマウスの位置の差異を足す。
                this.transform.position = objectPos + diff;
                //初めのマウスの位置を最新のマウスの位置に更新　
                firstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
}
