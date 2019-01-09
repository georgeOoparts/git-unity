using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s0013_atTransform : MonoBehaviour {
    //k0013:３ｄオブジェtransfome回り

    //k0013_1: 宣言 
    Transform page;

    void Start () {
        //k0013_1_1;オブジェに当てはめる；
        page = this.gameObject.GetComponent<Transform>();
    }
	
	void Update () {
        //k0013_1_1_1 オブジェ移動；
        page.position = new Vector3((float)-2.8, -5, 0);
    }
}
