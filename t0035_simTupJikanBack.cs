using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0035_simTupJikanBack : MonoBehaviour {
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる
    private float elapse;

    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        ////マウスを押した時
        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
        }
        //マウスを押している最中
        if (Input.GetMouseButton(0)) {
            Debug.Log(elapse);
        }
        //マウスボタンを離したら
        if (Input.GetMouseButtonUp(0)) {
            Debug.Log(elapse);
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
    }
}
