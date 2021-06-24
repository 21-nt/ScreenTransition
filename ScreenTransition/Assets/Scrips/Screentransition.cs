using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screentransition : MonoBehaviour
{
    public void CallSetting(){
        Call("Setting");
    }
    void Call(string scene){
        SceneManager.LoadScene(scene);
    }
}
