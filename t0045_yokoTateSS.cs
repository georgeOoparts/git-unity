using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0045_yokoTateSS : MonoBehaviour {
    //縦横スワイプをを判定するメソッド
    //単純横スワイプ
    //横成分が大きい場合のみ横スワイプ
    //横SSのみSS移動。普通のスワイプの動きはしない。

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
    private bool jikanShoriHantei = false;
    //一定の処理時間を決める変数
    public float timeOut = 1;
    //時間をためる変数
    private float tamaruTime;

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
            if (tateYokoHantei() == 1) {
                //マウスダウンの時とアップの時の差をdiffに入れる。
                diff = Input.mousePosition - firstPos;
                //SSならば
                if (hanteiSorScrollS() == 1) {
                    //論理時間処理判定変数が真になる。
                    jikanShoriHantei = true;
                    //upを判定するint変数
                }
                //SSならば
                else if (hanteiSorScrollS() == 1) {
                    //論理時間処理判定変数が真になる。
                    jikanShoriHantei = true;
                }
                //k6_ab:ストップウォッチの時間をリセット
                stopwatch.Reset();
            }
        }
        //論理時間処理判定関数が真ならば
        if (jikanShoriHantei) {
            //tamaruTimeに時間が溜まっていく
            tamaruTime += Time.deltaTime;
            //tamaruTimeが設定した時間を越えなければ
            if (tamaruTime <= timeOut) {
                //この中に時間内にしたい処理を書く。------
                //updownを判定するint変数が1ならば
                if (upDown == 1) {//オブジェ上移動
                    this.gameObject.transform.position +=
                   new Vector3(0, -chousei * Time.deltaTime, 0);
                } else if (upDown == 2) {//updownを判定するint変数が2ならば
                    //オブジェ下移動
                    this.gameObject.transform.position +=
                   new Vector3(0, chousei * Time.deltaTime, 0);
                }
                //-----------------------------------------
            } else {//tamaruTimeが設定した時間を越えたならば
                //論理時間処理判定変数が偽になる。
                jikanShoriHantei = false;
                //tamaruTimeが0にリセット
                tamaruTime = 0;
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
