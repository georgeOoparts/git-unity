﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

//マウスのスクリーンポイントをdebugLogに表示
public class k3_1_screenMousePoint : MonoBehaviour {
    // Update is called once per frame
	void Update () {
        //Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        Debug.Log(Input.mousePosition.ToString());
    }
}
