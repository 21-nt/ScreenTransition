using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    float originnum = 50f;
    float num = 50f;
    Slider Volume;
    // Start is called before the first frame update
    void Start()
    {
        Volume = GameObject.Find("Slider").GetComponent<Slider>();
        Volume.maxValue = 100f;
        Volume.value = 50f;
        originnum = Volume.value;
    }

    // Update is called once per frame
    void Update()
    {
        num = Volume.value;
        if (originnum != num){
            GameObject.Find("InputField").GetComponent<Text>().text = num.ToString();
        }
    }
}
