using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossBulletHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(),GameObject.FindWithTag("Boss").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            //GameObject.FindWithTag("Boss").SendMessage("bossHealthDecrease");
            Destroy(this.gameObject);
        }
    }
}
