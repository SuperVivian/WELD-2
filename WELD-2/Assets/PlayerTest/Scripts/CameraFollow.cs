using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target_1;
    public Transform target_2;
    Vector3 Offset;
    public float Speed = 10.0f;

    private Camera MyCamera;
    void Start()
    {
        MyCamera = GetComponent<Camera>();
        Offset = transform.position - (target_1.position + target_2.position)/2;
    }
    void FixedUpdate()
    {          
        Vector3 CamPos = (target_1.position + target_2.position) / 2 + Offset;//相机的位置跟随主角的位置而变化
        transform.position = Vector3.Lerp(transform.position, CamPos, Speed * Time.deltaTime);
        float distance = Vector3.Distance(target_1.position, target_2.position);
        float size = 4.0f * distance;
    //    MyCamera.orthographicSize = size;
    }

}
