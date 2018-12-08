using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//スクリーンポイントの距離をワールドの距離にしようとすると
//カメラ左下のポイントがなんだか入ってくる。注意。
public class t0024_sokudoChousei : MonoBehaviour {
    //スワイプの距離を入れるために使う変数。
    Vector3 objectPos;
    Vector3 firstPos;

    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;

    //1秒移動させるのに必要な変数
    private bool go = false;
    public float timeOut = 1;
    private float timeElapsed;


    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        if (Input.GetMouseButtonDown(0)) {
            stopwatch.Start();

            firstPos = Input.mousePosition;
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //Debug.Log(elapse);
            //フリックの感覚にする。下にフリックすると上へ移動
            //あくまでスクリーンポイント
            Vector3 diff= firstPos - Input.mousePosition;
            //Camera.main.ScreenToWorldPoint(
            //firstPos - Input.mousePosition);
            //diff = Camera.main.ScreenToWorldPoint(diff);

            //Debug.Log("f::" + firstPos
            //    //+"now::"+ Camera.main.ScreenToWorldPoint(Input.mousePosition)
            //    + "diff_x::" + diff.x
            //    + "diff_y::" + diff.y
            //    + "diff_z::" + diff.z
            //    );
            //Debug.Log(
            //);
        }
        //マウスを上げた時
        if (Input.GetMouseButtonUp(0)) {
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
    }
}
