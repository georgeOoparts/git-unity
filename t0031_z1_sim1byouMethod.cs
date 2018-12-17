using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t0031_z1_sim1byouMethod : MonoBehaviour {
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    public float interval = 0.35f;

    void Update() {
        timeHantei();
        
    }
    void timeHantei() {
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
        //k6_ab:ストップウォッチの時間をリセット
        //stopwatch.Reset();
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        Debug.Log(elapse);//何秒たったかを表示させたいときはこれを使う
    }
}
