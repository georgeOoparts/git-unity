using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0031_z1_sim1byouMethod : MonoBehaviour {
    //単純クリックすると（メインカメラが）一定時間、下移動するプログラム。

    //一定時間の処理をするかどうかのブール変数
    private bool jikanShoriHantei = false;
    //一定の処理時間を決める変数
    public float timeOut = 1;
    //時間をためる変数
    private float tamaruTime;

    //今回の下移動速度を調整するためだけの変数
    public float chousei = 10;

    void Update() {
        //左クリックされたら
        if (Input.GetMouseButtonDown(0)) {
            //論理時間処理判定変数が真になる。
            jikanShoriHantei = true;
        }
        //論理時間処理判定関数が真ならば
        if (jikanShoriHantei) {
            //tamaruTimeに時間が溜まっていく
            tamaruTime += Time.deltaTime;
            //tamaruTimeが設定した時間を越えなければ
            if (tamaruTime <= timeOut) {
                //この中に時間内にしたい処理を書く。
                this.gameObject.transform.position +=
                    new Vector3(0, -chousei * Time.deltaTime, 0);
            } else {//tamaruTimeが設定した時間を越えたならば
                //論理時間処理判定変数が偽になる。
                jikanShoriHantei = false;
                //tamaruTimeが0にリセット
                tamaruTime = 0;
            }
        }
    }
    //bool 1byouHantei() {

    //}

}
