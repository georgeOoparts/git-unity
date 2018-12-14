using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0023_z1_1byougoKai : MonoBehaviour {
    //スワイプの距離を入れるために使う変数。
    Vector3 objectPos;
    Vector3 firstPos=new Vector3(0,0,0);

    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    //SかSSか判定する変数。
    public float hanteiSorSS = 0.45f;
    //---------------------------------------------

    //SSするか判定する変数
    private bool goDown = false;
    private bool goUp = false;
    //
    public float timeOut = 1;
    private float timeElapsed;
    public float v = 10;
    public float t = 0.3f;
    public float chousei = 10;
    private float l = 1;
    ///SSするか判定する変数
    void Start() {

    }

    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();

            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
            //goDown = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            if (elapse <= hanteiSorSS) {
                Debug.Log("S::" + elapse);
            } else {
                Debug.Log("notS this is SS::" + elapse);
            }
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
        if (goDown) {
            sSwipe(2);
        }

        if (Input.GetMouseButtonDown(1)) {
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
            goUp = true;
        }
        if (goUp) {
            sSwipe(1);
        }

    }
    private void sSwipe(int i) {
        timeElapsed += Time.deltaTime;
        //下へ移動するときは、２
        if (i == 2) {
            if (timeElapsed <= timeOut) {
                this.gameObject.transform.position +=
                    new Vector3(0, -chousei * l / t * Time.deltaTime, 0);
            } else {
                goDown = false;
                timeElapsed = 0;
            }
        } 
        //上へ移動するときは、１
        else if (i == 1) {
            if (timeElapsed <= timeOut) {
                this.gameObject.transform.position +=
                    new Vector3(0, chousei * l / t * Time.deltaTime, 0);
            } else {
                goUp = false;
                timeElapsed = 0;
            }
        }

    }
}
