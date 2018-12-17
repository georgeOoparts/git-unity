using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0023_z2_1byouGo : MonoBehaviour {
    private bool go = false;
    public float timeOut = 1;
    private float tamaruTime;
    //public float v = 10;
    //public float t = 0.3f;
    public float chousei = 10;
    //private float l = 1;
    void Start() {

    }

    void Update() {
        //様々な条件がOKならば
        if (Input.GetMouseButtonDown(0)) {
            go = true;
        }
        //様々な条件がOKならば
        if (go) {
            //時間がたまっていく
            tamaruTime += Time.deltaTime;
            //一定時間時間以内ならば
            if (tamaruTime <= timeOut) {
                //----------ここに一定時間ないの処理を書く
                this.gameObject.transform.position +=
                    new Vector3(0, -chousei * Time.deltaTime, 0);
                //----------
            } else {//一定時間時間以外ならば
                go = false;
                tamaruTime = 0;
            }
        }
    }
}
