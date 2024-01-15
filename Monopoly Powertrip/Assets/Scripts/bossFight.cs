using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossFight : MonoBehaviour
{
    int bossHealth = 3;
    int bossDirection = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(bossFightStages());
    }

    IEnumerator bossFightStages()
    {
        if (bossHealth >= 3)
        {
            if (bossDirection == 1)
            {
                this.GetComponent<Transform>().Translate(Vector2.left * 0.01f);
            }
            if (bossDirection == 2)
            {
                this.GetComponent<Transform>().Translate(Vector2.right * 0.01f);
            }
        }
        else if(bossHealth >= 2)
        {
            //GameObject theBullet = Instantiate(GetComponent<weaponShoot>().bullet, GameObject.Find("bulletSpawn").transform);
            //theBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
            //yield return new WaitForSeconds(2);
            //Destroy(theBullet);
            //yield return new WaitForSeconds(2);
        }
        else if(bossHealth >= 1)
        {

        }
        else
        {
            Destroy(this.gameObject);
        }
        yield return new WaitForSeconds(2);
    }

    void randomBulletTime()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "leftSide")
        {
            bossDirection = 2;
        }
        if (collision.name == "rightSide")
        {
            bossDirection = 1;
        }
    }

}
