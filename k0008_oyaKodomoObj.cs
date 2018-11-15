using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目
public class k0008_oyaKodomoObj : MonoBehaviour {
    //GameObject kodomoObj1;
    //GameObject kodomoObj2;
    void Start () {
        //k8_a:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
        //kodomoObj1 = this.gameObject.transform.GetChild(0).gameObject;
        //k8_a:応用。孫になっているＯＢＪを得る。
        //kodomoObj2 = this.gameObject.transform.GetChild(1).gameObject;

        //k8_b:応用。親になっているＯＢＪを得る。
        //oyaPanel = this.gameObject.transform.parent.gameObject;
    }
}
