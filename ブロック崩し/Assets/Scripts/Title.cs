using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Game");
    }
}