using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目


public class t0017_1_pageText : MonoBehaviour {
     public GameObject page;  
    //Transform page;
	void Start () {
        Instantiate(page);
        //Instantiate(preNumber);
        //page = this.gameObject.GetComponent<Transform>();

        //Debug.Log("pagetext");
    }
	
	// Update is called once per frame
	void Update () {
        //for (int i = 1; i == 9; i++) {
            //transform.position = new Vector3(0, 5 - 10 * (i - 1), 0);
        //}
        //transform.position = new Vector3((float)-2.8, -5, 0);
    }
}
