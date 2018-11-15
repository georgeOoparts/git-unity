using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t0009_modoruButton : MonoBehaviour {
    int n;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // エスケープキー取得
        if (Input.GetKeyDown(KeyCode.Escape)) {
            // アプリケーション終了
            Application.Quit();
            return;
        }
    }
}

