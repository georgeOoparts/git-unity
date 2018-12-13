using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0026_SSorS_Move : MonoBehaviour {
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
    }
}
