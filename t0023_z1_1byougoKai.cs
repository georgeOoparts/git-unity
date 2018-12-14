using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0023_z1_1byougoKai : MonoBehaviour {
    //スワイプの距離を入れるために使う変数。
    Vector3 objectPos;
    Vector3 firstPos=new Vector3(0,0,0);

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
    void Start() {

    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            //最初にタップしたスクリーンポジションを入れる。
            firstPos = Input.mousePosition;
            goDown = true;
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
