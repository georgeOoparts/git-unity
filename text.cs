using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {
    int a = 3;
    int b = 10;
    void Start () {
        Debug.Log(plus(a,b));
	}
    int plus(int A,int B) {
        return (A + B);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
