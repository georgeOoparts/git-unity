﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0009_modoruButton : MonoBehaviour {
    int n;
	
    void Update () {
        // エスケープキー取得
        if (Input.GetKeyDown(KeyCode.Escape)) {
            // アプリケーション終了
            Application.Quit();
            return;
        }
    }
}

