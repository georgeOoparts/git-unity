using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class u0006_1_tenmetuPanel : MonoBehaviour {
    //オブジェクトを点滅させるプログラム
    //新公理当てはめまだ。
    
    
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    private float elapse;
    private bool mojiOnOff = true;
    public float interval = 0.35f;
    // Use this for initialization
    void Start() {
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //Debug.Log(elapse);//何秒たったかを表示させたいときはこれを使う
        if (mojiOnOff == true) {
            if (elapse >= interval) {
                mojiOnOff = false;
                //k7_a:オブジェを存在するけど見えなくする。
                this.gameObject.GetComponent<Image>().enabled = false;
                //k6_ab:ストップウォッチの時間をリセット
                stopwatch.Reset();
                //k6_aa:ストップウォッチスタート
                stopwatch.Start();
            }
        } else if (elapse >= interval) {
            mojiOnOff = true;
            //k7_b:オブジェを見えるようにするよ。
            this.gameObject.GetComponent<Image>().enabled = true;
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
        }
    }
}
