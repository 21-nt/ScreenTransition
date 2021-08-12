using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    #region Public Methods

    public float speed = 10.0f;

    void Update()
    {
        Vector3 tmpPos = this.transform.position;
        if(Input.GetKey(KeyCode.D) & tmpPos.x < 8)
        {
            tmpPos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) & tmpPos.x > -8)
        {
            tmpPos.x -= speed * Time.deltaTime;
        }

        this.transform.position = tmpPos;
    }

    #endregion
}
