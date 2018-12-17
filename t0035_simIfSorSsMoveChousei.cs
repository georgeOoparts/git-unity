using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0035_simIfSorSsMoveChousei : MonoBehaviour {
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    //単純クリックすると（メインカメラが）一定時間、下移動するプログラム。
    //で使う変数達。-------------------------------------
    //一定時間の処理をするかどうかのブール変数
    private bool jikanShoriHantei = false;
    //一定の処理時間を決める変数
    public float timeOut = 1;
    //時間をためる変数
    private float tamaruTime;

    //今回の下移動速度を調整するためだけの変数
    public float chousei = 10;
    //----------------------------------------------------

    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        ////マウスを押した時
        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
        }
        
        //マウスボタンを離したら
        if (Input.GetMouseButtonUp(0)) {
            //S_SS判定関数の戻り値1:Sの時
            if (hanteiSorScrollS() == 1) {
                //ここにSSの処理を書く
                //
                //this.transform.position =;

                Debug.Log("S");
            }
            //S_SS判定関数の戻り値2:SSの時
            else if (hanteiSorScrollS() == 2) {
                Debug.Log("SS");
            }
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
    }
    // 何秒たったかを変数elapseに入れる
    private float elapse;
    //時間判定の何秒以内かを決める変数。
    public float hanteiSorSS = 0.45f;

    //判定SorSS Sなら1、SSなら2を返す。
    int hanteiSorScrollS() {
        //経過時間elapseが判定時間hanteiSorSS以下ならば
        if (elapse <= hanteiSorSS) {
            //Debug.Log("S::" + elapse);
            return (1);
        } else {//経過時間elapseが判定時間hanteiSorSSより大きいならば
            //Debug.Log("notS this is SS::" + elapse);
            return (2);
        }
    }
}
