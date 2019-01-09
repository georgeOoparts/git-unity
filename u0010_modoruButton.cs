using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class u0010_modoruButton : MonoBehaviour {
    //アンドロイドの下のバーで←△矢印を押すと、
    //アプリ終了するプログラム
    //新公理なし

    int n;

    void Update() {
        // エスケープキー取得
        if (Input.GetKeyDown(KeyCode.Escape)) {
            // アプリケーション終了
            Application.Quit();
            return;
        }
    }
}

