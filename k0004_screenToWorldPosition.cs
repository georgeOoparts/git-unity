using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k0004_screenToWorldPosition : MonoBehaviour {

	
}
/*  k0004_screenToWorldPosition
    
    k0004_1_1_a1:スクリーン座標＞ワールド座標
    ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。

    position = Camera.main.ScreenToWorldPoint(position);
    
    具体例＞
    //k0003_1_1:Input.mousePositionでマウスのスクリーンポイントを
    //V3形式で代入
    V3 position=Input.mousePosition;
    
    //k0004_1_1_a1:スクリーン座標＞ワールド座標
    //ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。
    position = Camera.main.ScreenToWorldPoint(position);
    
    Debug.Log(position);
    
     
     
     
     
     */
