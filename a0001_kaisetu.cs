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
    k2::Text回り

    k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    -----------------
    k2_1_1:Textをこのオブジェクトで使うためのおまじない
    text = this.gameObject.GetComponent<Text>();
    -----------------
    k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
    text.text = "k2_1_TextContentChange";
    ------------------
    k2_1_1_2:スクリーン座標のテキスト幅   text.preferredWidth
    
    k2_1_1_3:スクリーン座標のテキスト高さ text.preferredHeight
    ---------------------------------------------------------------------------------------
    mouseposition回り
   
    //k0003_1:Input.mousePositionでマウスのスクリーンポイントを
    //V3形式で代入
    ////?
    Vector3 position=Input.mousePosition;

    //k0003_2:Input.mousePosition.ToString()でマウスのスクリーンポイントを
    //string形式で代入
    ////?
    string position=Input.mousePosition.ToString();
    
    >>具体例：：Debug.Log(Input.mousePosition.ToString());
    ---------------------------------------------------------------------------------------
    //k0003_3:一瞬左クリックダウン入力されたか出力０１
    Input.GetMouseButtonDown(0)
    
    >>具体例：：if (Input.GetMouseButtonDown(0)){・・・}

    //k0003_4:一瞬左クリックアップ入力されたか出力０１
    Input.GetMouseButtonUp(0)
    
    >>具体例：：if (Input.GetMouseButtonDown(0)){・・・}

    //k0003_5:左クリック押されてる間入力されたか出力０１
    Input.GetMouseButtonDown(0)
    
    >>具体例：：if (Input.GetMouseButton(0)){スライドするとか・・・}
    ---------------------------------------------------------------------------------------
    ////k0003_1:Input.mousePositionでマウスのスクリーンポイントを
    ////V3形式で代入
    ////?
    Vector3 position=Input.mousePosition;
    
    //k0003_6:スクリーン座標＞ワールド座標
    position = Camera.main.ScreenToWorldPoint(position);
    
    >>具体例：：ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。
    >>具体例：：Debug.Log(position);
    
//-------------------------------------------------------------

    //k0004_1_1_a1:スクリーン座標＞ワールド座標
    //ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。

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
    //k4_1:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;

    //k4_1_1:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
    rt = this.gameObject.GetComponent<RectTransform>();

    //k4_1_1_1:uiオブジェクトのスクリーン座標幅を得る
    rt.sizeDelta.x
    //k4_1_1_2:uiオブジェクトのスクリーン座標高さを得る
    rt.sizeDelta.y

    //k4_1_1_3:uiの幅、高さをスクリーン値で変形させる
    rt.sizeDelta = new Vector2(100,100);

    //k4_1_1_4:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
    rt.anchoredPosition = new Vector2(190, -145);
    //k4_1_1_5:uiをワールド値で移動
    rt.position = new Vector2(0,0);
//----------------------------------------------------------------------------
    //k5 メソッド　変数　外部から呼び出す。
    
    //k5_1_atStatic:静的変数を外のクラスから（クラス名）.(メソッド名)で呼び出す。
    public static int c = 200;
    
    //k5_2_atStatic:静的メソッドを外のクラスから（クラス名）.(メソッド名)で呼び出す。
    public static int plus(int A, int B) {
        return (A * B);
    }
//-------------------------------------------------------------------------------------
    //k6_stopwatch:
    
    //k6_1:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    
    //k6_1_1:何秒たったかを変数elapseに入れる-------
    ////?
    private float elapse;
    
    elapse = (float)stopwatch.Elapsed.TotalSeconds;
    -------------------------------------------------

    //k6_1_1_1:ストップウォッチスタート
    stopwatch.Start();
    
    //k6_1_1_2:ストップウォッチの時間をリセット
    stopwatch.Reset();
    
    具体例＞＞Debug.Log(elapse);//何秒たったかを表示させたいときはこれを使う
----------------------------------------------------------------------------------
    //k7オブジェクトを見えたり見えなくしたりする

    //k7_1:Imageコンポーネントを使う
    using UnityEngine.UI;

    //k7_1_1:オブジェを存在するけど見えなくする。
    this.gameObject.GetComponent<Image>().enabled = false;

    //k7_1_2:オブジェを見えるようにするよ。
    this.gameObject.GetComponent<Image>().enabled = true;
----------------------------------------------------------------------------------
    k8：：親、子供　オブジェ呼び出し

    //k8_1:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
    //自分の直下の子供を得る。
    kodomoObj1 = this.gameObject.transform.GetChild(0).gameObject;
    
    具体例：：応用。自分の孫になっているＯＢＪを得る。
    kodomoObj2 = this.gameObject.transform.GetChild(1).gameObject;

    //k8_2:応用。親になっているＯＢＪを得る。
    oyaPanel = this.gameObject.transform.parent.gameObject;
------------------------------------------------------------------------------
    //k10 float>int変換 
    ////?
    float fKazu=10.0f;
    
    //k10_1:float>int に小数点以下切り上げで変換。
    int kazu=(int)fKazu
     ---------------------------------------------------------------------
    k0011:textのぼやけを直す
    k0011:ヒエラルキー＞scaleを小さくして＞サイズ調整
    ----------------------------------------------------------------------
    k0012:3dtextをuitextの後ろに表示しようとする。
    k0012:uitextをカメラに固定カメラのｚポジション０
    ＞3dtextのｚポジション９０にするとなぜかuitextの後ろに3dtext表示される
    ----------------------------------------------------------------------
    //k0013:３ｄオブジェtransfome回り
    
    //k0013_1: 宣言 
    Transform page;
    
    //k0013_1_1;オブジェに当てはめる；
    page = this.gameObject.GetComponent<Transform>();
    
    //k0013_1_1_1 オブジェ移動；
    page.position = new Vector3((float)-2.8, -5, 0);
    ----------------------------------------------------------------------
    //k0014_1 :プレハブを使う objにはりつけ
    public GameObject page;
    
    //k0014_1_1 :プレハブを使う
    Instantiate(page);
    
    //k0014_1_2 :プレハブを使う 角度　位置を設定
    
    //配置する回転角を設定
    ////？
    Quaternion q = new Quaternion();
    q = Quaternion.identity;
    
    //位置を決定
    ////？
    Vector3 placePosition= new Vector3((float)-2.8, 5 - 10 * (i - 1), 0);
    
    GameObject obj =Instantiate(page, placePosition, q);

    //k0014_1_2_1 :プレハブを使う 位置、角度、さらに内容変更
    ////?
    obj.GetComponent<TextMesh>().text ="wowwow";
    ----------------------------------------------------------------------
   
     
     
     
     
     */
