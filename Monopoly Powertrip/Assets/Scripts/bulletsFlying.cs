using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsFlying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(bulletsFlyingOff());
        }
    }

    IEnumerator bulletsFlyingOff()
    {

        if (GetComponent<weaponShoot>().changeBullets == 1)
        {
            GameObject theBullet = Instantiate(GetComponent<weaponShoot>().bullet,GameObject.Find("bulletSpawn").transform);
            theBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10,0);
            yield return new WaitForSeconds(2);
            Destroy(theBullet);
        }
        if (GetComponent<weaponShoot>().changeBullets == 2)
        {
            GameObject theBullet = Instantiate(GetComponent<weaponShoot>().bullet,GameObject.Find("bulletSpawn").transform);
            theBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 10);
            yield return new WaitForSeconds(2);
            Destroy(theBullet);
        }
    }
}
