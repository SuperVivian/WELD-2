using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchbullets : MonoBehaviour {
    private RaycastHit hit;
    private Ray ray;
    public Vector3 raydirection;
    public GameObject bullets;
    public float timer;
    private float nowtimer;

	// Use this for initialization
	void Start () {
		ray = new Ray(this.gameObject.transform.position,raydirection );
        nowtimer = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(ray, out hit))
            if (hit.rigidbody.tag == "Player")
                if (nowtimer >= timer)
                {
                    GameObject bullet;
                    bullets bu;
                    bullet = Instantiate(bullets, this.transform);
                    bu = bullet.GetComponent<bullets>();
                    bu.dirr = raydirection.normalized;
                    timer = 0.0f;
                }
                else
                    nowtimer += Time.deltaTime;
    }
}
