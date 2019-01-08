using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k0003_zz2_screenToWorldPosition : MonoBehaviour {
    private Vector3 position;
    
	void Update () {
        
    }
}
/*
    k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
    position = Input.mousePosition;
    
    k3_zz2_a:スクリーン座標＞ワールド座標
    position = Camera.main.ScreenToWorldPoint(position);
    
    ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。
    Debug.Log(position);
     
     */
