using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0022_yukuriSwipe : MonoBehaviour {
    public float bunkatuSuu = 10;
    public float idouKyori = -10;
    public float idouJikan = 1;

    public float timeOut=3;
    private float timeElapsed;

    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    int i=0;
    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        stopwatch.Start();

        //timeElapsed += Time.deltaTime;

        //if (timeElapsed >= timeOut) {
        //    // Do anything
        //    Debug.Log(elapse);
        //    timeElapsed = 0.0f;
        //}
        //マウスを押した時
        //if (Input.GetMouseButtonDown(0)) {
        //    float perIdoukyori = idouKyori / bunkatuSuu;
        //    float perIdouJikan = idouJikan/bunkatuSuu;
        //    //k6_aa:ストップウォッチスタート
        //    stopwatch.Start();
        //    //for (float i=1;i<=bunkatuSuu;i++) {
        //        this.transform.position +=
        //        new Vector3(0, idouKyori*Time.deltaTime, 0);
        //    //}
        //}

        //if (Time.deltaTime * i <= 5) {
        //    stopwatch.Start();
        //    this.transform.position +=
        //       new Vector3(0, idouKyori * Time.deltaTime, 0);
        //    i++; Debug.Log(elapse);
        //}  
        //if (Input.GetMouseButton(0)) {
        //    Vector3 startPosition = new Vector3(0,0,0);
        //    Vector3 endPosition = new Vector3(0, -10, 0);
        //    float rate = 1;
        //    stopwatch.Start();
            this.transform.position +=
               new Vector3(0, idouKyori/10 * Time.deltaTime, 0);
        //    //this.transform.position = 
        //        //Vector3.Lerp(startPosition, endPosition, rate);
        //}

    }
}
