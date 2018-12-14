using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0023_z1_1byougoKai : MonoBehaviour {
    private bool go = false;
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
            go = true;
        if (go) {
            sSwipe();
        }
    }
    private void sSwipe() {
        timeElapsed += Time.deltaTime;
        if (timeElapsed <= timeOut) {
            this.gameObject.transform.position +=
                new Vector3(0, -chousei * l / t * Time.deltaTime, 0);
        } else {
            go = false;
            timeElapsed = 0;
        }
    }
}
