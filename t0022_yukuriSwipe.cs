using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0022_yukuriSwipe : MonoBehaviour {
    public float bunkatuSuu = 10;
    public float idouKyori = -10;
    public float idouJikan = 2;

    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;

    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //マウスを押した時
        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            this.transform.position +=new Vector3(0, idouKyori,0);
        }
    }
}
