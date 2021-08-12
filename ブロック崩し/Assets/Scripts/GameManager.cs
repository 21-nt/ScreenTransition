using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject WallR;
    public GameObject WallL;
    public GameObject WallT;
    public GameObject WallB;
    public GameObject Paddle;
    public GameObject Ball;

    public Ball ballScript;
    public Text scoreText;
    public int score;
    public GameObject result;
    public GameObject Pause;
    public Text resultText;
    public int blockCnt;
    public int ballCnt;
    public int ballMax = 3;
    public int width = 7;
    public int height = 2;
    bool ispause;

    public GameObject BlockPrefab;
    Vector2 pausedirection;
    Vector3 pauseposition;


    public void Start()
    {
        score = 0;
        blockCnt = 0;
        ballCnt = 0;
        ispause = false;
        result.SetActive(false);
        Pause.SetActive(false);
        ballScript = Ball.GetComponent<Ball>();

        float w = BlockPrefab.transform.localScale.x * 1.3f;
        float h = BlockPrefab.transform.localScale.z * 1.5f;

        for (int i = -width; i <= width; i++)
        {
            for (int j = -height; j <= height; j++)
            {
                GameObject block;
                block = Instantiate(BlockPrefab, new Vector3(i * w, 0, j * h + 10.0f), Quaternion.identity);
                block.GetComponent<Block>().gm = this;
            }
        }
    }

    private void Update()
    {
        scoreText.text = score.ToString();

        if (
            blockCnt == (width * 2 + 1) * (height * 2 + 1) 
            || ballCnt == ballMax
            )
        {
            Ball.SetActive(false);
            resultText.text = "Your Score is " + score.ToString();
            result.SetActive(true);
        }

        if (
            Ball.transform.position.z - Ball.transform.localScale.z / 2 <= WallB.transform.position.z + WallB.transform.localScale.z / 2
            && ballCnt < ballMax
        )
        {
            ballCnt++;
            Ball.transform.position = new Vector3 (0f, 0f, 0f);
            Ball.GetComponent<Ball>().direction = new Vector2 (1f, 1f);
        }

        if (
            Input.GetKey(KeyCode.Space)
            && ispause == false
        )
        {
            pausedirection = Ball.GetComponent<Ball>().direction;
            Ball.GetComponent<Ball>().direction = new Vector2 (0, 0);
            Pause.SetActive(true);
            ispause = true;
        }
    }

    public void OffPause()
    {
        Ball.GetComponent<Ball>().direction = pausedirection;
        Pause.SetActive(false);
        ispause = false;
    }
}
