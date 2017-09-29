using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOn : MonoBehaviour {
    public Animator Anim_Switch;
    public Animator Anim_Wall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Anim_Switch.SetTrigger("SwitchOn");
            Anim_Wall.SetTrigger("SwitchOn");
        }
    }
}
