using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MgDestroy : MonoBehaviour {
    public float machinegunHp;
    public float takeDamage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (machinegunHp <= 0)
            Destroy(this.gameObject);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 14)
            machinegunHp -= takeDamage;

    }
}
