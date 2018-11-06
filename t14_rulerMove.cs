using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class t14_rulerMove : MonoBehaviour {
    private Vector3 objectPos;
    private Vector3 mousePos;

    void Start () {
        //Debug.Log("rulerMove");
	}
	void Update () {
        playerControl();
    }
    private void playerControl() {

        if (Input.GetMouseButtonDown(0)) {
            objectPos = this.transform.position;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0)) {

            Vector3 prePos = this.transform.position;
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mousePos;

            diff.z = 0.0f;
            this.transform.position = objectPos + diff;

        }
        if (Input.GetMouseButtonUp(0)) {
            objectPos = Vector3.zero;
            mousePos = Vector3.zero;
        }
    }
}
