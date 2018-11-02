using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class t14_rulerMove : MonoBehaviour {
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    
    void Start () {
        Debug.Log("rulerMove");
	}
	
	// Update is called once per frame
	void Update () {
        //k9_a:左クリック入力 ボタンダウンInput.GetMouseButtonDown(0)
        //具体例：：if (Input.GetMouseButtonDown(0)) count++;
        if (Input.GetMouseButtonDown(0)) {
            touchStartPos = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,
                                        Input.mousePosition.z);
        }
        //k9_b:左クリック入力　ボタンアップInput.GetMouseButtonUp(0)
        //具体例：：if (Input.GetMouseButtonDown(0)) count++;
        if (Input.GetMouseButtonUp(0)) {
            touchEndPos = new Vector3(Input.mousePosition.x,
                                      Input.mousePosition.y,
                                      Input.mousePosition.z);
        }
       
        Debug.Log(touchEndPos);
    }
}
