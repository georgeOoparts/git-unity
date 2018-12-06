using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0023_1byouGo : MonoBehaviour {
    private bool go = false;
    public float timeOut=1;
    private float timeElapsed;
    public float v=10;
	void Start () {

    }
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
            go = true;
        if (go) {
            timeElapsed += Time.deltaTime;
            if (timeElapsed <= timeOut) {
                this.gameObject.transform.position +=
                    new Vector3(0, -v * Time.deltaTime, 0);
            } else {
                go = false;
                timeElapsed = 0;
            }
        }
	}
}
