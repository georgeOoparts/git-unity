using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//単純クリックすると（メインカメラが）一定時間、下移動するプログラム。
//上スワイプすると（メインカメラが）下移動するプログラム、
//下スワイプすると（メインカメラが）上移動するプログラム、追加
public class t0037_1byouMoveUpDownVchousei : MonoBehaviour {
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
    public float chousei = 10;

    void Update() {
        //マウスボタンを押したらならば
        if (Input.GetMouseButtonDown(0)) {
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
        }
        //マウスボタンを押している最中
        if (Input.GetMouseButtonUp(0)) {
            //upTupされたら
            if (upDownHantei() == 1) {
                //論理時間処理判定変数が真になる。
                jikanShoriHantei = true;
                //upを判定するint変数
                upDown = 1;
            } else if (upDownHantei() == 2) {
                //論理時間処理判定変数が真になる。
                jikanShoriHantei = true;
                //updownを判定するint変数
                upDown = 2;
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
                if (upDown == 1) {
                    //オブジェ上移動
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
    //マウス入力upは1、downは2,どちらでもないは0を返す。
    int upDownHantei() {
        Vector3 diff = Input.mousePosition - firstPos;
        if (diff.y > 0) {
            //Debug.Log("up");
            return (1);
        } else if (diff.y < 0) {
            //Debug.Log("down");
            return (2);
        } else return (0);
    }
}
