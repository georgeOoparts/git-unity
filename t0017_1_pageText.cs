using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目


public class t0017_1_pageText : MonoBehaviour {
     public GameObject page;  
    //Transform page;
	void Start () {
        //k0014_ ；プレハブを使う
        //Instantiate(page);
        //Instantiate(preNumber);
        //page = this.gameObject.GetComponent<Transform>();

        //Debug.Log("pagetext");
        for (int i = 1; i <= 9; i++) {
            //配置する回転角を設定
            Quaternion q = new Quaternion();
            q = Quaternion.identity;
            //transform.position = new Vector3(0, 5 - 10 * (i - 1), 0);
            Vector3 placePosition
                = new Vector3((float)-2.8, 5 - 10 * (i - 1), 0);
            GameObject obj=Instantiate(page, placePosition, q);
            
            obj.GetComponent<TextMesh>().text =i.ToString();

        }
    }
	
	// Update is called once per frame
	void Update () {
        
        
        //transform.position = new Vector3((float)-2.8, -5, 0);
    }
}
