using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screentransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Call("SampleScene");
    }

    // Update is called once per frame
    public void CallSetting(){
        Call("Setting");
    }
    void Call(string scene){
        SceneManager.LoadScene(scene);
    }
}
