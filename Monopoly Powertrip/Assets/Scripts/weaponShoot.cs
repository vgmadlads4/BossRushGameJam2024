using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponShoot : MonoBehaviour
{
    public bool changeBullets = true;
    public GameObject bullet;
    public GameObject bulletTwo;
    public GameObject bulletThree;
    public int change_Bullets = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            change_Bullets = 1;
        }
        else if (Input.GetKeyDown("2"))
        {
            change_Bullets = 2;
        }
        else if(Input.GetKeyDown("3"))
        {
            change_Bullets = 3;
        }
    }
}
