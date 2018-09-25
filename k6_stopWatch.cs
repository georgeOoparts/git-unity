using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//k6_stopwatch:
public class k6_stopWatch : MonoBehaviour {
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    //public float interval = 0.35f;
    // Use this for initialization
    void Start () {
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
        //k6_ab:ストップウォッチの時間をリセット
        stopwatch.Reset();
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //Debug.Log(elapse);//何秒たったかを表示させたいときはこれを使う
    }
}
