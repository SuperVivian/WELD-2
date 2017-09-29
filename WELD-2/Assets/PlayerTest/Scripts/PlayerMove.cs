using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float MoveSpeed = 10.0f;
    public float JumpSpeed = 10.0f;
    private Rigidbody rb;
    //public string button;
    public string AxisHorizontal;
    public string AxisVertical;
    public KeyCode JumpCode;
    public bool IsGround = false;
    public bool LeftWall = false;
    public bool RightWall = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {                   
             //移动
        float h = Input.GetAxis(AxisHorizontal);
        float v = Input.GetAxis(AxisVertical);

        if (h > 0.1f)
        {
            rb.AddForce(Vector3.right * MoveSpeed * 100.0f * Time.deltaTime);
        }
        if (h < -0.1f)
        {
            rb.AddForce(-Vector3.right * MoveSpeed * 100.0f * Time.deltaTime);
        }
        if (Input.GetKeyDown(JumpCode))
        {
            //跳跃
            if (IsGround)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = JumpSpeed;
                rb.velocity = velocity;
            }
        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "T_Ground")
        {
            IsGround = true;
        }else if(col.gameObject.tag == "LeftWall")
        {
            IsGround = true;
            LeftWall = true;
        }else if(col.gameObject.tag == "RightWall")
        {
            IsGround = true;
            RightWall = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "T_Ground")
        {
            IsGround = false;
        }
    }

    //若有需要，可更改手柄顺序
    //public void ExchangeJoyStick()
    //{
    //    if (button == "FirstA")
    //    {
    //        button = "SecondA";
    //    }
    //    else if (button == "SecondA")
    //    {
    //        button = "FirstA";
    //    }

    //    if (AxisHorizontal == "FirstHorizontal")
    //    {
    //        AxisHorizontal = "SecondHorizontal";
    //    }
    //    else if (AxisHorizontal == "SecondHorizontal")
    //    {
    //        AxisHorizontal = "FirstHorizontal";
    //    }
    //    if (AxisHorizontal == "FirstVertical")
    //    {
    //        AxisHorizontal = "SecondVertical";
    //    }
    //    else if (AxisHorizontal == "SecondVertical")
    //    {
    //        AxisHorizontal = "FirstVertical";
    //    }
    //}
}
