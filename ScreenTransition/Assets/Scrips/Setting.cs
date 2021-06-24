using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    float normal;
    float originnum;
    float num;
    string text;
    Slider Volume;
    float inputnum;
    float origininput;
    // Start is called before the first frame update
    void Start()
    {
        Volume = GameObject.Find("Slider").GetComponent<Slider>();
        Volume.maxValue = 100f;
        originnum = num = inputnum = origininput = Volume.value = normal;
        inputField().text = "50.0";
    }

    // Update is called once per frame
    void Update()
    {
        num = Volume.value;
        text = inputField().text;
        if(text == ""){
            inputnum = 0;
        }
        else{
            inputnum = float.Parse(text);
        }
        if (inputnum != origininput){
            Volume.value = inputnum;
            origininput = inputnum;
        }
        else if (originnum != num){
            if(num == 0){
                inputField().text = "";
            }
            else{
                inputField().text = num.ToString();
            }
            originnum = num;
        }
    }
    InputField inputField(){
            return GameObject.Find("InputField").GetComponent<InputField>();
        }
}
