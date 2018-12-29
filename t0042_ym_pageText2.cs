using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t0042_ym_pageText2 : MonoBehaviour {
    public GameObject page;

    public float yoyuu = 0.0f;

    void Start() {
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
            //まずは目次のページから
            Vector3 placePosition
                = new Vector3((float)-2.8, 5 - 10 * (i - 1), 1);
            GameObject obj = Instantiate(page, placePosition, q);

            obj.GetComponent<TextMesh>().text = i.ToString();

            //フラグのページ
            Vector3 placePositionF
                = new Vector3((float)2.8+yoyuu, 5 - 10 * (i - 1), 1);
            GameObject objF = Instantiate(page, placePositionF, q);

            objF.GetComponent<TextMesh>().text ="F"+ i.ToString();

            //RRのページ
            Vector3 placePositionR
                = new Vector3((float)8.4+yoyuu, 5 - 10 * (i - 1), 1);
            GameObject objR = Instantiate(page, placePositionR, q);

            objR.GetComponent<TextMesh>().text = "R" + i.ToString();

        }
    }

    // Update is called once per frame
    void Update() {


        //transform.position = new Vector3((float)-2.8, -5, 0);
    }
}
