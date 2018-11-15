using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class k0005_atStatic : MonoBehaviour {
    //k5_a_atStatic:静的変数を外のクラスから（クラス名）.(メソッド名)で呼び出す。
    public static int c = 200;
    //k5_b_atStatic:静的メソッドを外のクラスから（クラス名）.(メソッド名)で呼び出す。
    public static int plus(int A, int B) {
        return (A * B);
    }
}
