using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour {
    public GameObject[] white;
    public GameObject[] black;
    public GameObject light1;
    public int numberStairs;
    public Script4change level;
    public float timer;
    private bool whitee;
    private bool blackk;
    private bool hasnotrun;
    private float starttime;

	// Use this for initialization
	void Start ()
    {
        whitee = true;
        blackk = false;
        hasnotrun = true;
        starttime = timer;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (level.levelnum == 3)
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                if (whitee && hasnotrun)
                {
                    for (int i = 0; i < numberStairs; i++)
                    {
                        white[i].SetActive(false);
                        black[i].SetActive(true);
                    }

                    whitee = false;
                    blackk = true;
                    hasnotrun = false;
                    light1.SetActive(false);
                }

                if (blackk && hasnotrun)
                {
                    for (int i = 0; i < numberStairs; i++)
                    {
                        white[i].SetActive(true);
                        black[i].SetActive(false);
                    }

                    whitee = true;
                    blackk = false;
                    hasnotrun = false;
                    light1.SetActive(true);
                }

                timer = starttime;
                hasnotrun = true;
            }
        }

	}
}
