using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//PointerEventDataを使うため下が必要。
using UnityEngine.EventSystems;

//ruler 四角形の左下と右上のスクリーンポイントを表示するプログラム
public class t0014_rulerMove : MonoBehaviour {
    //private Vector3 objectPos;
    private Vector3 mousePos;

    private bool on=false;

    void Update () {
        //Debug.Log("rulerMove");
        if (Input.GetMouseButtonDown(0)) {
            //マウスが対象ＵＩの上にあったらtrue
            if (clickUiCheck()) {
                on = true;
            }
            if (on) flickControl();

        }        
    }
    Vector3 objectPos;
    Vector3 firstPos;
    private void flickControl() {
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            firstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(":firsr:"+firstPos);
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            objectPos = this.transform.position;
            Debug.Log("obj::"+objectPos);
            //Vector3 prePos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            Vector3 diff =
                firstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(diff);
            //タッチ対応デバイス向け、1本目の指にのみ反応
            //if (Input.touchSupported) {
            //    diff =
            //Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) 
            //- mousePos;
            //}

            if (diff != Vector3.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diff.x = 0.0f;
                diff.z = 0.0f;

                this.transform.position = objectPos + diff;
                firstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        //マウスを上げたら
        //if (Input.GetMouseButtonUp(0)) {
        //    objectPos = Vector3.zero;
        //    mousePos = Vector3.zero;
        //}
    }
    private bool clickUiCheck() {
        //マウスが対象ＵＩの上にあったらtrue,
        //なかったらfalseを返す   
        PointerEventData pointer
                = new PointerEventData(EventSystem.current);
        pointer.position = Input.mousePosition;
        List<RaycastResult> result = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer, result);

        foreach (RaycastResult raycastResult in result) {
            // ここに名前を取得する処理を書く
            // 複数ある場合は全て取得されるため注意
            if (raycastResult.gameObject.name == "ruler") {
                return (true);
            }
        }
        return (false);
    }
}
