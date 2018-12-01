using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
//PointerEventDataを使うため下が必要。
using UnityEngine.EventSystems;

//ruler 四角形の左下と右上のスクリーンポイントを表示するプログラム
//UIをスワイプしている点に注意。オブジェとちょっと違う。
public class t0014_rulerMove : MonoBehaviour {

    void Update () {
        if (clickUiCheck()) flickControl();
    }

    Vector2 uiPos;
    Vector2 firstPos;
    private void flickControl() {
        
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            firstPos = Input.mousePosition;
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            uiPos = 
            this.gameObject.GetComponent<RectTransform>().anchoredPosition;
            //Vector3 prePos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            Vector2 diff =
                new Vector2(Input.mousePosition.x,Input.mousePosition.y)
                - firstPos;
            Debug.Log(diff);
            //タッチ対応デバイス向け、1本目の指にのみ反応
            //if (Input.touchSupported) {
            //    diff =
            //Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) 
            //- mousePos;
            //}

            if (diff != Vector2.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diff.x = 0.0f;
                //diff.z = 0.0f;

                this.gameObject.GetComponent<RectTransform>().anchoredPosition 
                    = uiPos + diff;
                firstPos
                    = Input.mousePosition;
            }
        }
    }
    //クリックした所にＵＩがあるかどうかを判定するメソッド
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
