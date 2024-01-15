using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponShoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletTwo;
    public GameObject bulletThree;
    public int changeBullets = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            changeBullets = 1;
        }
        else if (Input.GetKeyDown("2"))
        {
            changeBullets = 2;
        }
        else if(Input.GetKeyDown("3"))
        {
            changeBullets = 3;
        }
    }
}
