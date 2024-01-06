using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponShoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletTwo;
    public bool changeBullets = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (changeBullets == true)
        {
            if (Input.GetKeyDown("c"))
            {
                changeBullets = false;
            }
        }
        else if (changeBullets == false)
        {
            if (Input.GetKeyDown("c"))
            {
                changeBullets = true;
            }
        }
    }
}
