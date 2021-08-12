using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameManager gm;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        Vector3 tPos = gm.Ball.transform.position;
        Vector3 scale = this.transform.localScale;
        Vector3 tScale = gm.Ball.transform.localScale;


        if (
            tPos.x - tScale.x / 2 <= pos.x + scale.x /2
            && tPos.x + tScale.x / 2 >= pos.x - scale.x / 2
            && tPos.z - tScale.z / 2 <= pos.z + scale.z / 2
            && tPos.z + tScale.z /2 >= pos.z - scale.z / 2
        )
        {
            if (
                tPos.x + tScale.x / 2 >= pos.x - scale.x / 2 + 1.0f
                && gm.ballScript.direction.x < 0
            )
            {
                gm.ballScript.direction.x *= -1.0f;
                this.gameObject.SetActive(false);
            }

            if (
                tPos.x - tScale.x / 2 <= pos.x + scale.x / 2 - 1.0f
                && gm.ballScript.direction.x > 0
            )
            {
                gm.ballScript.direction.x *= -1.0f;
                this.gameObject.SetActive(false);
            }

            if (
                tPos.z + tScale.z / 2 >= pos.z - scale.z / 2 + 0.1f
                && gm.ballScript.direction.y < 0
            )
            {
                gm.ballScript.direction.y *= -1.0f;
                this.gameObject.SetActive(false);
            }

            if (
                tPos.z - tScale.z / 2 <= pos.z + scale.z / 2 - 0.1f
                && gm.ballScript.direction.y > 0
            )
            {
                gm.ballScript.direction.y *= -1.0f;
                this.gameObject.SetActive(false);
            }

            gm.score += 10;
            this.gameObject.SetActive(false);
            gm.score += 10;
            gm.blockCnt++;
        }
    }
}
