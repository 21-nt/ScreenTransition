using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Ball : MonoBehaviour
{
//初速を入力値として準備します。
public float speed = 100;
 
private void Start()
{
// rigidbodyを取得
Rigidbody rb = this.GetComponent<Rigidbody>();
// 力を設定
Vector3 force = new Vector3(10.0f,10.0f,0.0f)*speed; 
// 力を加える
rb.AddForce(force); 
}
}