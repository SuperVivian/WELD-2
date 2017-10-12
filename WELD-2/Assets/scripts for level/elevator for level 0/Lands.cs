using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lands : MonoBehaviour
{
    public switch1 switch11;
    public switch2 switch22;
    public bool isgo;
    public float maxy;
    public float miny;



    private void Start()
    {
        isgo = false;
    }

    private void Update()
    {
        if (switch11.isactive1 && switch22.isactive2 == false)
        {
            if (maxy - this.gameObject.transform.position.y > this.gameObject.transform.position.y - miny)
            {
                isgo = true;
                switch11.isactive1 = false;

            }
            else
                return;
        }

        if (switch11.isactive1 == false && switch22.isactive2)
        {
            if (maxy - this.gameObject.transform.position.y < this.gameObject.transform.position.y - miny)
            {
                isgo = true;
                switch22.isactive2 = false;
            }
            else
                return;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isgo = true;
        }
    }


}
