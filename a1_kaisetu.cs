using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a1_kaisetu : MonoBehaviour {

    //g1 最新のコミットメッセージを変更
    //g1 ６下ファイルステータス＞８オブションのコミット＞最後のコミットを上書き
    //g2 無駄に枝別れしたブランチを消す
    //g2 根元を○にする＞無駄枝トップのブランチを右クリ
    //g2＞現在のブランチをこのコミットまでリセット（hard）
    //g3無駄に進んだブランチを前の状態に戻す
    //g3 無駄に進んだブランチを○にする＞戻したい所のコミットを右クリ
    //g3＞現在のブランチをこのコミットまでリセット（hard）
    //g4 masterを前の段階に戻す＞masterを○にする＞戻したい所のコミットを右クリ
    //g4＞現在のブランチをこのコミットまでリセット（hard）

    //u1 呼び込まれるプログラムの順番　１上側＞edit>projectseting>scriptexecutionOrder  
    //u1>数字が低いほうから読み込まれる。

    //k1　デバックログの使い方
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    //k2_aa:Textをこのオブジェクトで使うためのおまじない
    //k2_aaa:text.text = "・・・ "でTEXTのないよう変更。
    //k2_aab1:スクリーン座標のテキスト幅   text.preferredWidth
    //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight
    //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
    //k3_zz2_a:スクリーン座標＞ワールド座標
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
    //k4_aaa1:uiオブジェクトのスクリーン座標幅を得る
    //k4_aaa2:uiオブジェクトのスクリーン座標高さを得る
    //k4_aab:uiの幅、高さをスクリーン値で変形させる
    //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
    //k4_aac2:uiをワールド値で移動
    //k5_a_atStatic:静的変数を外のクラスから（クラス名）.(メソッド名)で呼び出す。
    //k5_b_atStatic:静的メソッドを外のクラスから（クラス名）.(メソッド名)で呼び出す。
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    //k6_aa:ストップウォッチスタート
    //k6_ab:ストップウォッチの時間をリセット
    //k6_ac:何秒たったかを変数elapseに入れる
    //k7_a:オブジェを存在するけど見えなくする。
    //k7_b:オブジェを見えるようにするよ。
    //k8_a:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
    //k9_a:左クリック入力　Input.GetMouseButtonDown(0)



}
