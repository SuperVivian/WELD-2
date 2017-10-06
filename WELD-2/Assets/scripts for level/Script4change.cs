using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4change : MonoBehaviour {

    public int levelnum = 1;
    public Camera Cam_tramsform;
    public float health;
    public Vector3 respawnposition;
    public Vector3 level2Cam;
    public Vector3 level3Cam;
    public Vector3 level4Cam;
    public Transform[] levelrespawn;
    public float timer;
    private Vector3 movement;
    public float Cam_speed;
    public bool ispassLevel;
    public Transform Player1;
    public Transform Player2;
    private float jianting;

    // Use this for initialization
    void Start()
    {
        health = 1.0f;
        ispassLevel = false;
        jianting = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0.0f)
            ddeath();

        switch (levelnum)
        {
            case 2:
                Cam_tramsform.transform.position = level2Cam;
                break;

            case 3:
                Cam_tramsform.transform.position = level3Cam;
                break;
            case 4:
                Cam_tramsform.transform.position = level4Cam;
                break;
            default:

                break;


        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "levelbox" || other.tag == "level4respawn")
        {
            if (other.gameObject.name == "level2repawn")
                levelnum = 2;
            if (other.gameObject.name == "level3respawn")
                levelnum = 3;
            if (other.tag == "level4respawn")
            {
                levelnum = 4;
                if (jianting <= 2.0f)
                {
                    print("okok");
                    Player1.position = levelrespawn[2].position;
                    Player2.position = levelrespawn[2].position + new Vector3(-3.0f, 0.0f, 0.0f);
                    jianting += 1.0f;
                }
            }


            respawnposition = levelrespawn[levelnum
                - 2].position;
            ispassLevel = true;

        }

        if (other.gameObject.layer == 14 && health != 0)
            health -= 1.0f;


        if (other.tag == "deathline")
            ddeath();
    }

    void LevelStart()
    {

    }

    void ddeath()
    {
        timer -= Time.deltaTime * 2.0f;
        if (timer <= 0.0f)
            Respawn();
        print("isdead");
    }


    void Respawn()
    {
        transform.position = respawnposition;
        print("Respawn");
        health = 1.0f;
        timer = 0.1f;
    }
}
