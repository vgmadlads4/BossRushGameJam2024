using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootButton : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (GetComponent<weaponShoot>().changeBullets)
            {
                GameObject newBulletOne = Instantiate(bullet, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                Destroy(newBulletOne, 3f);

            }
            else
            {
                GameObject newBulletTwo = Instantiate(bulletTwo, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                Destroy(newBulletTwo, 3f);
            }
        }
    }
}
