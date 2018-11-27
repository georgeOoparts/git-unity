using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//タッチしている時間をデバックログに表示
public class t0018_tupwacth : MonoBehaviour {
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    public float interval = 0.35f;
    
    void Update () {
        
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //マウスを押した時
        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            Debug.Log(elapse);
        }
        //マウスを上げた時
        if (Input.GetMouseButtonUp(0)) {
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
    }
}
