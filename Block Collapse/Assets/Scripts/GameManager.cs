using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Public Fields

    public GameObject ClearUI;
    public GameObject GameOverUI;
    public GameObject BlockPrefab;

    #endregion


    #region Public Methods

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1 = GameObject.FindGameObjectsWithTag("Player").Length;

        if (count == 0)
        {
            ClearUI.SetActive(true);
        }

        if (count1 == 0 && count != 0)
        {
            GameOverUI.SetActive(true);
        }
    }

    #endregion

    #region Private Methods

    private void Start()
    {
        float w = BlockPrefab.transform.localScale.x * 1.2f;
        float h = BlockPrefab.transform.localScale.z * 4;

        for (int i = -2; i <= 2; i++)
        {
            for (int j = 0; j <= 4; j++)
            {
                GameObject block;

                block = Instantiate(BlockPrefab, new Vector3(i * w, j * h +30.0f, 0), Quaternion.identity);
            }
        }
    }

    #endregion
}
