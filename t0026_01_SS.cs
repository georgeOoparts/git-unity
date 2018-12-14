using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//スクロールスワイプするだけ。
public class t0026_01_SS : MonoBehaviour {
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    //SかSSか判定する変数。
    public float hanteiSorSS = 0.45f;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        ////マウスを押した時
        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
        }
        if (Input.GetMouseButton(0)) {
            Debug.Log(elapse);

        }
        if (Input.GetMouseButtonUp(0)) {
            if (elapse <= hanteiSorSS) Debug.Log("S::" + elapse);
            else Debug.Log("notS this is SS::" + elapse);

            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
        //普通下　スワイプの為のメソッド
        sSwipe();
    }
    Vector3 objectPos;
    Vector3 firstPos;
    private void sSwipe() {
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

                this.transform.position = objectPos + diff;
                firstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
}
