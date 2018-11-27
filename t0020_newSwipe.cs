using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//単純な上下フリック完成
public class t0020_newSwipe : MonoBehaviour {
    Vector3 objectPos;
    Vector3 firstPos;
    
	void Update () {
        flickControl();
    }

    private void flickControl() {
        
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            //
            firstPos = 
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            objectPos = this.transform.position;
            //Vector3 prePos = this.transform.position;
            Vector3 diff =
                Camera.main.ScreenToWorldPoint(Input.mousePosition) - firstPos;

            //タッチ対応デバイス向け、1本目の指にのみ反応
            //if (Input.touchSupported) {
            //    diff =
            //Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) 
            //- mousePos;
            //}
            diff.x = 0.0f; 
            diff.z = 0.0f;
            if(diff!=Vector3.zero)
                this.transform.position = objectPos + diff;
            firstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        //マウスを上げたら
        //if (Input.GetMouseButtonUp(0)) {
        //    objectPos = Vector3.zero;
        //    mousePos = Vector3.zero;
        //}
    }
}
