using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a0001_kaisetu : MonoBehaviour {

    
}
/*
    命名規則
    k0001_1_hoge>k0001_2_hoge
    前の記述を前提にしている物
    k0001_1_1>k0002_1_1_2

    //説明　今回の定理名　公理名
    ////引用元
    
    //-----------------------------------------------------------
    //AC_a1:アンドロイド端末でステータスバーとナビゲーションバーを常に表示 
    //オブジェにApplicationChrome.csをアタッチ。
    //同じオブジェにスクリプトをアタッチ。
    //スクリプトのスタートに下の文字列を書く。
    ApplicationChrome.statusBarState=ApplicationChrome.State.Visible;

    //AC_a2:ステータスバーだけを表示
    ApplicationChrome.statusBarState=ApplicationChrome.State.Visible;
    ApplicationChrome.navigationBarState=ApplicationChrome.State.Hidden;

    //AC_a3:ナビゲーションバーだけを表示
    ApplicationChrome.navigationBarState=ApplicationChrome.State.Visible;

    //AC_b1:ステータスバー、ナビゲーションバーの状態を変える
    //通常　ApplicationChrome.statusBarState=ApplicationChrome.State.Visible;
    //画面に映る物の上にかぶせる
    ApplicationChrome.statusBarState=
                ApplicationChrome.State.VisiblOverContent;
    //透明になりながら画面に映るもののうえにかぶさる
    ApplicationChrome.statusBarState=
                ApplicationChrome.State.TranslucentOverContent;
    //隠す
    ApplicationChrome.statusBarState=ApplicationChrome.State.Hidden;
    ------------------------------------------------------------------------------

    //g1 最新のコミットメッセージを変更
    //g1 ６下ファイルステータス＞８オブションのコミット＞最後のコミットを上書き
    //g2 無駄に進んだ（枝別れでも良し）したブランチを戻す
    //g2 無駄に進んだブランチを選択＞無駄に進んだブランチを右クリっク
    　＞このコミットを打ち消す＞枝分かれの根元を右クリック
     ＞このコミットまでリセット＞hard
    ------------------------------------------------------------------------------

    u1 呼び込まれるプログラムの順番　１上側＞edit>projectseting
    >scriptexecutionOrder  
    u1>数字が低いほうから読み込まれる。
    ------------------------------------------------------------------------------

    //k1　デバックログの使い方
    
    //k1_1 デバッグログ表示
    Debug.Log("デバックログはこうやるぜee");
    
    //k1_2 デバッグログ　変数　表示----ー----------------
    ////?
    int hensu = 9999;
    Debug.Log(hensu);
    
    //k1_3 デバッグログ　変数＋　表示----ー----------------
    ////?
    int hensu = 9999;
    Debug.Log("wowow"+hensu);

    ----------------------------------------------------------
    k2_1_a1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
     -----------------
     k2_1_a2:Textをこのオブジェクトで使うためのおまじない
     text = this.gameObject.GetComponent<Text>();
     -----------------
     k2_1_a3:text.text = "・・・ "でTEXTのないよう変更。
     text.text = "k2_1_TextContentChange";
     ------------------
     k2_1_a4:スクリーン座標のテキスト幅 text.preferredWidth
     k2_1_a5:スクリーン座標のテキスト高さ text.preferredHeight
    -------------------------------------------------------------
    k0003:mouseposition回り
    
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
    
//-------------------------------------------------------------

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
//----------------------------------------------------------------------------
    //k4_1_a1:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;

    //k4_1_a2:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
    rt = this.gameObject.GetComponent<RectTransform>();

    //k4_a3_1:uiオブジェクトのスクリーン座標幅を得る
    rt.sizeDelta.x
    //k4_a3_2:uiオブジェクトのスクリーン座標高さを得る
    rt.sizeDelta.y

    //k4_a3_3:uiの幅、高さをスクリーン値で変形させる
    rt.sizeDelta = new Vector2(100,100);

    //k4_a3_4:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
    rt.anchoredPosition = new Vector2(190, -145);
    //k4_a3_5:uiをワールド値で移動
    rt.position = new Vector2(0,0);
//----------------------------------------------------------------------------
    
    k5_a_atStatic:静的変数を外のクラスから（クラス名）.(メソッド名)で呼び出す。
    k5_b_atStatic:静的メソッドを外のクラスから（クラス名）.(メソッド名)で呼び出す。
    k6_a:ストップウォッチ関数を使う時のおまじない。
    k6_aa:ストップウォッチスタート
    k6_ab:ストップウォッチの時間をリセット
    k6_ac:何秒たったかを変数elapseに入れる
    k7_a:オブジェを存在するけど見えなくする。
    k7_b:オブジェを見えるようにするよ。
    k8_a:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
    k8_b:応用。親になっているＯＢＪを得る。
    k8_b:oyaPanel = this.gameObject.transform.parent.gameObject;
    
    k10_kataHenkan
    k10:float>int に小数点以下切り上げで変換。
    k10:int kazu=(int)fKazu
    k0011:textのぼやけを直す
    k0011:ヒエラルキー＞scaleを小さくして＞サイズ調整
    k0012:3dtextをuitextの後ろに表示しようとする。
    k0012:uitextをカメラに固定カメラのｚポジション０
    ＞3dtextのｚポジション９０にするとなぜかuitextの後ろに3dtext表示される
    k0013:３ｄオブジェtransfome回り
    k0013_a1: 宣言 Transform page;
    k0013_b1;オブジェに当てはめる；
    >page = this.gameObject.GetComponent<Transform>();
    k0013_c1 オブジェ移動；
    >transform.position = new Vector3((float)-2.8, -5, 0);
    k0014_00 :プレハブを使う objにはりつけ
    public GameObject page;
    k0014_a :プレハブを使う
    Instantiate(page);
    k0014_b1 :プレハブを使う 角度　位置
    配置する回転角を設定
    Quaternion q = new Quaternion();
    q = Quaternion.identity;
          transform.position = new Vector3(0, 5 - 10 * (i - 1), 0);
          Vector3 placePosition
                = new Vector3((float)-2.8, 5 - 10 * (i - 1), 0);
           GameObject obj =Instantiate(page, placePosition, q);
    k0014_b2 :プレハブを使う さらに内容変更
    GameObject obj = Instantiate(page, placePosition, q);
    obj.GetComponent<TextMesh>().text =i.ToString();
     
     
     
     
     */
