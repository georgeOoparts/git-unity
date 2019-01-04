using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0048_debugTime : MonoBehaviour {
    //デバックログリアルタイム時間表示
    //新しいヴァージョンのunityではアプリで設定できる。
    
    //k1　デバックログの使い方
    string debugTime;
	// Use this for initialization
	void Start () {
        //リアルタイムの時間を取得
        debugTime = System.DateTime.Now.Hour.ToString()+"時"
            + System.DateTime.Now.Minute.ToString()+"分"
            + System.DateTime.Now.Second.ToString()+"秒"
            + System.DateTime.Now.Millisecond.ToString();

        Debug.Log(debugTime+"<color=red>(・∀・)ｲｲ!!</color>");
	}
}
