using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//マウスのスクリーンポイントをdebugLogに表示
public class k0003_screenMousePoint : MonoBehaviour {
    
}
/*  mouseposition回り
   
    
    k0003_1_1:Input.mousePositionでマウスのスクリーンポイントを
    V3形式で代入
    V3 position=Input.mousePosition;

    k0003_1_2:Input.mousePosition.ToString()でマウスのスクリーンポイントを
    string形式で代入
    string position=Input.mousePosition.ToString();
    具体例：：Debug.Log(Input.mousePosition.ToString());
    ---------------------------------------------------------------------------------------
    k0003_2_1:一瞬左クリックダウン入力されたか出力０１Input.GetMouseButtonDown(0)
    具体例：：if (Input.GetMouseButtonDown(0)){・・・}

    k0003_2_2:一瞬左クリックアップ入力されたか出力０１Input.GetMouseButtonUp(0)
    具体例：：if (Input.GetMouseButtonDown(0)){・・・}

    k0003_2_3:左クリック押されてる間入力されたか出力０１Input.GetMouseButtonDown(0)
    具体例：：if (Input.GetMouseButton(0)){スライドするとか・・・}

    
    
    
     
*/
