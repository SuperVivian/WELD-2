using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lands : MonoBehaviour
{
    public Vector3 position1;
    public Vector3 position2;
    public float state;
    //state ==1.0f means the land is on the top of elevator;

    private void Start()
    {
        state = 1.0f;
    }

    private void Update()
    {
   
    }


    void Judgetheposition()
    {
        if (this.gameObject.transform.position.y >= position1.y)
            state = 1.0f;
        if (this.gameObject.transform.position.y <= position2.y)
            state = 2.0f;
    }

}
