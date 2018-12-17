using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0034_simSwipeKyoriBack : MonoBehaviour {

    void Update() {
        //タップした距離（y軸）をスクリーンポイントで返す関数。
        Debug.Log(
        tupDistanseScreenBack().y
        );
    }
    //タップした最初のポジションを表示
    Vector3 firstPos;
    //タップしたy軸の距離をv3スクリーンポイントで返すメソッド
    //下スワイプ　＋の値、上スワイプ　－の値
    Vector3　tupDistanseScreenBack() {
        //マウスボタンを押したら
        if (Input.GetMouseButtonDown(0)) {
            //firstPosに現在のスクリーンポイントを入れる
            firstPos = Input.mousePosition;
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //フリックの感覚にする。下にフリックすると上へ移動
            Vector3 diff = firstPos - Input.mousePosition;
            return (diff);
        }
        return new Vector3(0,0,0);
    }
}

