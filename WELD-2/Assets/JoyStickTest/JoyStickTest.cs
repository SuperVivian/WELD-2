using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickTest : MonoBehaviour {
    public float MoveSpeed = 10.0f;
    public float JumpSpeed = 10.0f;
    private Rigidbody rb;
    public string button;
    public string AxisHorizontal;
    public string AxisVertical;

    public bool IsGround = false;
    public bool ButtonDown;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        ButtonDown = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("E down");
            ExchangeJoyStick();
        }
        if (Input.GetButtonDown(button))
        {
            ButtonDown = true;
            if (IsGround)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = JumpSpeed;
                rb.velocity = velocity;
            }
        }

        float h = Input.GetAxis(AxisHorizontal);
        float v = Input.GetAxis(AxisVertical);

        if (h > 0.1f)
        {
            rb.AddForce(Vector3.right * MoveSpeed * Time.deltaTime);
        }
        if (h < -0.1f)
        {
            rb.AddForce(-Vector3.right * MoveSpeed * Time.deltaTime);
        }

    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "T_Ground")
        {
            IsGround = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "T_Ground")
        {
            IsGround = false;
        }
    }

    public void ExchangeJoyStick()
    {
        if(button == "FirstA")
        {
            button = "SecondA";
        }else if (button == "SecondA")
        {
            button = "FirstA";
        }

        if (AxisHorizontal == "FirstHorizontal")
        {
            AxisHorizontal = "SecondHorizontal";
        }else if (AxisHorizontal == "SecondHorizontal")
        {
            AxisHorizontal = "FirstHorizontal";
        }
        if (AxisHorizontal == "FirstVertical")
        {
            AxisHorizontal = "SecondVertical";
        }else  if (AxisHorizontal == "SecondVertical")
        {
            AxisHorizontal = "FirstVertical";
        }
    }
}
