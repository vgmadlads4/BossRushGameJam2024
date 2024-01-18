using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossFight : MonoBehaviour
{
    public int bossHealth = 9;
    public int bossDirection = 1;
    public GameObject bossBullet;

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
        while (bossHealth >= 0)
        {
            if (bossHealth <= 9 && bossHealth > 6)
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
            else if (bossHealth <= 6 && bossHealth > 3)
            {
                this.GetComponent<Transform>().Translate(Vector2.zero);
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().gravityScale = 0;
                //yield return new WaitForSeconds(1);
                int randomPlace = Random.Range(0, 4);
                switch (randomPlace)
                {
                    case 0:
                        this.GetComponent<Transform>().position = GameObject.Find("topLeft").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    case 1:
                        this.GetComponent<Transform>().position = GameObject.Find("topRight").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    case 2:
                        this.GetComponent<Transform>().position = GameObject.Find("bottomLeft").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    case 3:
                        this.GetComponent<Transform>().position = GameObject.Find("bottomRight").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    default:
                        this.GetComponent<Transform>().position = GameObject.Find("topLeft").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                }
            }
            yield return null; ;
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

    public void bossHealthDecrease()
    {
        bossHealth--;
    }

    IEnumerator bulletsFlyingOff()
    {
        GameObject theBullet = Instantiate(bossBullet);

        //theBullet.GetComponent<Transform>().LookAt(GameObject.FindWithTag("Player").GetComponent<Transform>().position);
        //Vector2 playerPosition = GameObject.FindWithTag("Player").GetComponent<Transform>().position;
        //print(playerPosition);
        //GameObject.FindWithTag("Player").GetComponent<Transform>().position.
        //theBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(GameObject.FindWithTag("Player").GetComponent<Transform>().position.x - this.GetComponent<Transform>().position.x, GameObject.FindWithTag("Player").GetComponent<Transform>().position.y - this.GetComponent<Transform>().position.y);
        yield return new WaitForSeconds(2);
        Destroy(theBullet);
    }

}
