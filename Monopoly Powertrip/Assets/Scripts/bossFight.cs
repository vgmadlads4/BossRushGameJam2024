using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossFight : MonoBehaviour
{
    public int bossHealth = 9;
    public int bossDirection = 1;
<<<<<<< HEAD
=======
    public GameObject bossBullets;
>>>>>>> Second_Stage_Of_The_First_Boss_1_16_2024

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bossFightStages());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator bossFightStages()
    {
<<<<<<< HEAD
        if (bossHealth > 6 && bossHealth <=9)
=======
        while(bossHealth > 0)
>>>>>>> Second_Stage_Of_The_First_Boss_1_16_2024
        {
            if (bossHealth > 6 && bossHealth <= 9)
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
            if (bossHealth > 3 && bossHealth <= 6)
            {
<<<<<<< HEAD
                this.GetComponent<Transform>().Translate(Vector2.right * 0.01f);
            }
        }
        else if(bossHealth > 3 && bossHealth <= 6)
        {
            //GameObject theBullet = Instantiate(GetComponent<weaponShoot>().bullet, GameObject.Find("bulletSpawn").transform);
            //theBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
            //yield return new WaitForSeconds(2);
            //Destroy(theBullet);
            //yield return new WaitForSeconds(2);
        }
        else if(bossHealth <= 3 && bossHealth > 0)
        {

        }
        else 
        {
            Destroy(this.gameObject);
=======
                yield return new WaitForSeconds(1);
                this.GetComponent<Rigidbody2D>().gravityScale = 0;
                int randomPlace = 0; //Random.Range(0, 4);

                switch (randomPlace)
                {
                    case 0:
                        this.GetComponent<Transform>().position = GameObject.Find("topLeft").transform.position;
                        Vector2 theTop = GameObject.Find("top").GetComponent<Transform>().position;
                        GameObject theBossBullet = Instantiate(bossBullets, theTop, GameObject.Find("top").GetComponent<Transform>().rotation);
                        Vector2 bossBulletVector = GameObject.Find("top").GetComponent<Transform>().position;
                        Vector2 playerPosition = GameObject.FindWithTag("Player").GetComponent<Transform>().position;
                        theBossBullet.GetComponent<Rigidbody2D>().velocity = Vector2.MoveTowards(bossBulletVector, playerPosition, 1000f);
                        yield return new WaitForSeconds(2);
                        Destroy(theBossBullet);
                        break;
                    case 1:
                        this.GetComponent<Transform>().position = GameObject.Find("topRight").transform.position;
                        break;
                    case 2:
                        this.GetComponent<Transform>().position = GameObject.Find("bottomLeft").transform.position;
                        break;
                    case 3:
                        this.GetComponent<Transform>().position = GameObject.Find("bottomRight").transform.position;
                        break;
                    default:
                        this.GetComponent<Transform>().position = GameObject.Find("topLeft").transform.position;
                        break;
                }
                yield return new WaitForSeconds(5);
            }
            yield return null;
>>>>>>> Second_Stage_Of_The_First_Boss_1_16_2024
        }
        yield return null;
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            bossHealth = bossHealth - 1;
        }
    }

}
