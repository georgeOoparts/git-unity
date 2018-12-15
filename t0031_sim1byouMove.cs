using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0031_sim1byouMove : MonoBehaviour {
    //単純クリックすると（メインカメラが）一定時間、下移動するプログラム。
    
    //一定時間の処理をするかどうかのブール変数
    private bool jikanShori = false;
    //一定の処理時間を決める変数
    public float timeOut = 1;
    //時間をためる変数
    private float tamaruTime;

    //今回の下移動速度を調整するためだけの変数
    public float chousei = 10;
   

    void Update () {
        if (Input.GetMouseButtonDown(0))
            jikanShori = true;
        if (jikanShori) {
            tamaruTime += Time.deltaTime;
            if (tamaruTime <= timeOut) {
                //この中に時間内にしたい処理を書く。
                this.gameObject.transform.position +=
                    new Vector3(0, -chousei * Time.deltaTime, 0);
            } else {
                jikanShori = false;
                tamaruTime = 0;
            }
        }

    }
}
