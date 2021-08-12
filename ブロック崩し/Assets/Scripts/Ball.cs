using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Vector2 direction;

    public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        direction.x = 1.0f;
        direction.y = 1.0f;
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        if (
            this.transform.position.x + this.transform.localScale.x / 2 >= gm.WallR.transform.position.x - gm.WallR.transform.localScale.x / 2
            && direction.x > 0
            )
        {
            direction.x *= -1.0f;
        }
        if (
            this.transform.position.x - this.transform.localScale.x / 2 <= gm.WallL.transform.position.x + gm.WallL.transform.localScale.x / 2
            && direction.x < 0
            )
        {
            direction.x *= -1.0f;
        }
        if (
            this.transform.position.z + this.transform.localScale.z / 2 >= gm.WallT.transform.position.z - gm.WallT.transform.localScale.z / 2
            && direction.y > 0
            )
        {
            direction.y *= -1.0f;
        }

        if (
            this.transform.position.x <= gm.Paddle.transform.position.x + gm.Paddle.transform.localScale.x / 2
            && this.transform.position.x >= gm.Paddle.transform.position.x - gm.Paddle.transform.localScale.x / 2
            && this.transform.position.z - this.transform.localScale.z / 2 <= gm.Paddle.transform.position.z + gm.Paddle.transform.localScale.z / 2
            && this.transform.position.z + this.transform.localScale.z / 2 >= gm.Paddle.transform.position.z - gm.Paddle.transform.localScale.z / 2
            && direction.y < 0
            )
        {
            direction.y *= -1.0f;
        }
        Vector3 tmpPos = this.transform.position;
        tmpPos.x += speed * direction.x * Time.deltaTime;
        tmpPos.z += speed * direction.y * Time.deltaTime;
        this.transform.position = tmpPos;
    }
}
