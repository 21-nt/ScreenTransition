using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    #region Public Fields

    public float speed = 10;

    #endregion


    #region Public Methods

    void Update()
    {
        Transform BarTrans = GameObject.Find("Bar").transform;
        Vector3 pos = BarTrans.position;

        float speed1 = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (pos.x < 20)
            {
                this.transform.Translate(speed1, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (pos.x > -20)
            {
                this.transform.Translate(-speed1, 0f, 0f);
            }
        }
    }

    #endregion
}
