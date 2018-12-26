using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0044_ym_yokoSwipe : MonoBehaviour {
    //縦横スワイプをを判定するメソッド
    //単純横スワイプ
    
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
        flickControl();
    }
    Vector3 objectPos;
    Vector3 FCfirstPos;
    private void flickControl() {
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            //最初のマウスの位置
            FCfirstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //動かされるカメラの現在の位置
            objectPos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            //初めのマウスの位置と今のマウスの位置の差異
            Vector3 diffSwipe =
                FCfirstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //初めのマウスの位置と今のマウスの位置の差異が0じゃなければ
            if (diffSwipe != Vector3.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diffSwipe.y = 0.0f;
                diffSwipe.z = 0.0f;
                //カメラの位置にマウスの位置の差異を足す。
                this.transform.position = objectPos + diffSwipe;
                //初めのマウスの位置を最新のマウスの位置に更新　
                FCfirstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }

    //縦横スワイプをを判定するメソッド
    int tateYokoHantei() {
        Vector3 tateYokoDiff = Input.mousePosition - firstPos;
        if (tateYokoDiff.x < 0) tateYokoDiff.x = tateYokoDiff.x * -1;
        if (tateYokoDiff.y < 0) tateYokoDiff.y = tateYokoDiff.y * -1;

        if (tateYokoDiff.x > tateYokoDiff.y) {
            //横移動の方が大きければ１を返す
            return (1);
        } else {
            //縦移動の方が大きいか同じならば２を返す
            return (2);
        }
    }
}
