using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpForce = 680.0f; //publicにするとインスペクターに登場し、動かしながら調整をすることができるようになる。めっちゃ便利
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       //ジャンプする
       if(Input.GetKeyDown(KeyCode.Space))
       {
        //ローカル座標で上にジャンプする
        this.rigid2D.AddForce(transform.up*this.jumpForce);
        /*
        ワールド座標系で上にジャンプする
        this.rigid2D.AddForce(Vector3.up*this.jumpForce);
        */
       } 
    }
}
