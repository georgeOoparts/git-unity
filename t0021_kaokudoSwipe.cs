using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0021_kaokudoSwipe : MonoBehaviour {
    public float kasokudo = 10;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
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
            firstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            objectPos = this.transform.position;
            //Vector3 prePos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            Vector3 diff =
                firstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //タッチ対応デバイス向け、1本目の指にのみ反応
            //if (Input.touchSupported) {
            //    diff =
            //Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) 
            //- mousePos;
            //}

            if (diff != Vector3.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diff.x = 0.0f;
                diff.z = 0.0f;

                this.transform.position = objectPos + diff*kasokudo;
                firstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
}
