using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0041_sorssVchousei : MonoBehaviour {
    //単純クリックすると（メインカメラが）一定時間、下移動するプログラム。
    //上スワイプすると（メインカメラが）下移動するプログラム、
    //下スワイプすると（メインカメラが）上移動するプログラム、追加
    //S,SS切り分け、SSだったら上、下スワイプ　追加、Sだったら何もやらない。
    //SSだったらSS、Sなら普通のスワイプ
    //ssの時、タップでssを止める
    //SSの速度調整も追加　スワイプ距離でSSの速度が決まる

    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;
    //時間判定の何秒以内かを決める変数。hanteiSorScrollS()で使う
    public float hanteiSorSS = 0.45f;

    //upDownHantei
    //スワイプの距離を入れるために使う変数。
    Vector3 firstPos = new Vector3(0, 0, 0);
    //upDownHantei
    //上下判定で使う変数
    int upDown = 0;

    //一定時間の処理をするかどうかのブール変数
    private bool jikanShoriHantei = false;
    //一定の処理時間を決める変数
    public float timeOut = 1;
    //時間をためる変数
    private float tamaruTime;

    //今回の下移動速度を調整するためだけの変数
    public float chousei = 0.07f;

    //マウスダウンの時とアップの時の差をdiffに入れる。
    Vector3 diff = new Vector3(0, 0, 0);

    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //マウスボタンを押したらならば
        if (Input.GetMouseButtonDown(0)) {
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
        }
        //マウスボタンを押している最中
        if (Input.GetMouseButtonUp(0)) {
            //マウスダウンの時とアップの時の差をdiffに入れる。
            diff = Input.mousePosition - firstPos;
            if (upDownHantei() == 1//upTupされたら
                && hanteiSorScrollS() == 1//SSならば
                ) {
                //論理時間処理判定変数が真になる。
                jikanShoriHantei = true;
                //upを判定するint変数
                upDown = 1;
            } else if (upDownHantei() == 2//downTupされたら
                 && hanteiSorScrollS() == 1//SSならば
                ) {
                //論理時間処理判定変数が真になる。
                jikanShoriHantei = true;
                //updownを判定するint変数
                upDown = 2;
            }
            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
        }
        //論理時間処理判定関数が真ならば
        if (jikanShoriHantei) {
            //SS中にタップがあったらSSを止める
            if (Input.GetMouseButtonDown(0)) {
                tamaruTime = timeOut;
            }
            //tamaruTimeに時間が溜まっていく
            tamaruTime += Time.deltaTime;
            //tamaruTimeが設定した時間を越えなければ
            if (tamaruTime <= timeOut) {
                //この中に時間内にしたい処理を書く。------
                //diffがプラスかマイナスかによって上下の方向が決まる
                this.gameObject.transform.position +=
                   new Vector3(0, -chousei*diff.y * Time.deltaTime, 0);
                                //-----------------------------------------
            } else {//tamaruTimeが設定した時間を越えたならば
                //論理時間処理判定変数が偽になる。
                jikanShoriHantei = false;
                //tamaruTimeが0にリセット
                tamaruTime = 0;
            }
        }
        flickControl();
    }
    Vector3 objectPos;
    Vector3 FCfirstPos;
    private void flickControl() {
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            //最初のマウスの位置
            FCfirstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //動かされるカメラの現在の位置
            objectPos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            //初めのマウスの位置と今のマウスの位置の差異
            Vector3 diffSwipe =
                FCfirstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //初めのマウスの位置と今のマウスの位置の差異が0じゃなければ
            if (diffSwipe != Vector3.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diffSwipe.x = 0.0f;
                diffSwipe.z = 0.0f;
                //カメラの位置にマウスの位置の差異を足す。
                this.transform.position = objectPos + diffSwipe;
                //初めのマウスの位置を最新のマウスの位置に更新　
                FCfirstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
    //マウス入力upは1、downは2,どちらでもないは0を返す。
    int upDownHantei() {
        //Vector3 diff = Input.mousePosition - firstPos;
        if (diff.y > 0) {
            //Debug.Log("up");
            return (1);
        } else if (diff.y < 0) {
            //Debug.Log("down");
            return (2);
        } else return (0);
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
}
