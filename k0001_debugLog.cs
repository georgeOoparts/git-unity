using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//k1　デバックログの使い方
public class k0001_debugLog : MonoBehaviour {
    int hensu = 9999;
	// Use this for initialization
	void Start () {
        Debug.Log("デバックログはこうやるぜee"+hensu);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
