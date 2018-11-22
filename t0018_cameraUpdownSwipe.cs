﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class t0018_cameraUpdownSwipe : MonoBehaviour {
    private Vector3 objectPos;
    private Vector3 mousePos;
    // Use this for initialization
    void Start () {
        //Debug.Log("updownswipe");
    }
	
	// Update is called once per frame
	void Update () {
        flickControl();
    }
    private void flickControl() {
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            objectPos = this.transform.position;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {

            //Vector3 prePos = this.transform.position;
            Vector3 diff =
                Camera.main.ScreenToWorldPoint(Input.mousePosition) - mousePos;

            //タッチ対応デバイス向け、1本目の指にのみ反応
            //if (Input.touchSupported) {
            //    diff =
            //Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) 
            //- mousePos;
            //}
            diff.z = 0.0f;
            this.transform.position = objectPos + diff;

        }
        //マウスを上げたら
        if (Input.GetMouseButtonUp(0)) {
            objectPos = Vector3.zero;
            mousePos = Vector3.zero;
        }
    }
}
