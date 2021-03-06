﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0047_yokoSsMove : MonoBehaviour {
    //縦横スワイプをを判定するメソッド
    //単純横スワイプ
    //横成分が大きい場合のみ横スワイプ
    //横SSのみSS移動。普通のスワイプの動きはしない。実験
    //横SSが1秒の動きをするよう調整　→移動
    //横SSが途中で止まるように調整
    //→だけじゃなく←移動もできるようにする
    //とりあえず横移動完成
    //横移動の使いまわし変数tukaimawasiPos追加

    //スワイプの距離を入れるために使う変数。
    Vector3 firstPos;

    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;
    //時間判定の何秒以内かを決める変数。hanteiSorScrollS()で使う
    public float hanteiSorSS = 0.45f;

    //マウスダウンの時とアップの時の差をdiffに入れる。
    Vector3 diff = new Vector3(0, 0, 0);

    //一定時間の処理をするかどうかのブール変数
    public static bool yokojikanShoriHantei = false;
    //一定の処理時間を決める変数
    public float timeOut = 1;
    //時間をためる変数
    private float tamaruTime;

    //今回の下移動速度を調整するためだけの変数
    public float chousei = 10;

    //横移動の時の目次、フラグ、SSを位置を定める
    int yokoPosi = 1;

    //横移動の使いまわし変数
    Vector3 tukaimawasiPos = new Vector3(0,0,0);

    public float yokoHanteiHaba = 0.01f;

    


    //private void Start() {
    //    GameObject camera = this.gameObject;
    //    Vector3 camPos=camera.transform.position;
    //    camera.transform.position = new Vector3(108,camPos.y,camPos.z);
    //}

    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)) {
            //←→判定の判定のためだけに使うdiff
            diff = Input.mousePosition - firstPos;

            if (yokoHanteiHaba >= diff.y && diff.y>=-yokoHanteiHaba) {
                if (tateYokoHantei() == 1) {
                    //SSならば
                    if (hanteiSorScrollS() == 1) {
                        //論理時間処理判定変数が真になる。
                        yokojikanShoriHantei = true;
                    }
                }
            }
            //k6_ab:ストップウォッチの時間をリセット       
            stopwatch.Reset();
        }
        //論理時間処理判定関数が真ならば
        if (yokojikanShoriHantei) {
            if (yokoPosi == 1) {
                //←フリックなら→移動
                if (diff.x < 0) {
                    if (this.gameObject.transform.position.x <= 5.6) {
                        
                        //オブジェ移動
                        this.gameObject.transform.position +=
                            new Vector3(chousei * Time.deltaTime,0,0);
                    } else {
                        //tukaimawasiPos.yとかやるために変数に一旦入れる
                        tukaimawasiPos = this.gameObject.transform.position;
                        //オブジェ移動
                        this.gameObject.transform.position =
                            new Vector3((float)5.6,
                            tukaimawasiPos.y,tukaimawasiPos.z);
                        //論理時間処理判定変数が偽になる。
                        yokojikanShoriHantei = false;
                        yokoPosi = 2;
                    }
                }
            } else if (yokoPosi == 2) {
                //←フリックなら→移動
                if (diff.x < 0) {
                    if (this.gameObject.transform.position.x <= 11.2) {
                        //オブジェ移動
                        this.gameObject.transform.position +=
                            new Vector3(chousei * Time.deltaTime, 0, 0);
                    } else {
                        //tukaimawasiPos.yとかやるために変数に一旦入れる
                        tukaimawasiPos = this.gameObject.transform.position;
                        //オブジェ移動
                        this.gameObject.transform.position =
                            new Vector3((float)11.2,
                            tukaimawasiPos.y, tukaimawasiPos.z);
                        //論理時間処理判定変数が偽になる。
                        yokojikanShoriHantei = false;
                        yokoPosi = 3;
                    }
                }
                //→フリックなら←移動
                else if (diff.x > 0) {
                    if (this.gameObject.transform.position.x > 0) {
                        //オブジェ移動
                        this.gameObject.transform.position -=
                            new Vector3(chousei * Time.deltaTime, 0, 0);
                    } else {
                        //tukaimawasiPos.yとかやるために変数に一旦入れる
                        tukaimawasiPos = this.gameObject.transform.position;
                        //オブジェ移動
                        this.gameObject.transform.position =
                            new Vector3((float)0, 
                            tukaimawasiPos.y, tukaimawasiPos.z);
                        //論理時間処理判定変数が偽になる。
                        yokojikanShoriHantei = false;
                        yokoPosi = 1;
                    }
                }
            } else if (yokoPosi == 3) {
                //→フリックなら←移動
                if (diff.x > 0) {
                    if (this.gameObject.transform.position.x > 5.6) {
                        //オブジェ移動
                        this.gameObject.transform.position -=
                            new Vector3(chousei * Time.deltaTime, 0, 0);
                    } else {
                        //tukaimawasiPos.yとかやるために変数に一旦入れる
                        tukaimawasiPos = this.gameObject.transform.position;
                        //オブジェ移動
                        this.gameObject.transform.position =
                            new Vector3((float)5.6, 
                            tukaimawasiPos.y, tukaimawasiPos.z);
                        //論理時間処理判定変数が偽になる。
                        yokojikanShoriHantei = false;
                        yokoPosi = 2;
                    }
                }
            }
        }
    }
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
    //縦横スワイプをを判定するメソッド
    int tateYokoHantei() {
        Vector3 tateYokoDiff = Input.mousePosition - firstPos;
        if (tateYokoDiff.x < 0) tateYokoDiff.x = tateYokoDiff.x * -1;
        if (tateYokoDiff.y < 0) tateYokoDiff.y = tateYokoDiff.y * -1;

        if (tateYokoDiff.x > tateYokoDiff.y) {
            //横移動の方が大きければ１を返す
            return (1);
        } else {
            //縦移動の方が大きいか同じならば２を返す
            return (2);
        }
    }
}
