using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0023_z1_1byougoKai : MonoBehaviour {
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
        if (Input.GetMouseButtonDown(0))
            goDown = true;
        if (goDown) {
            sSwipe(2);
        }

        if (Input.GetMouseButtonDown(1))
            goUp = true;
        if (goUp) {
            sSwipe(1);
        }

    }
    private void sSwipe(int i) {
        timeElapsed += Time.deltaTime;
        if (i == 2) {
            if (timeElapsed <= timeOut) {
                this.gameObject.transform.position +=
                    new Vector3(0, -chousei * l / t * Time.deltaTime, 0);
            } else {
                goDown = false;
                timeElapsed = 0;
            }
        } else if (i == 1) {
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
