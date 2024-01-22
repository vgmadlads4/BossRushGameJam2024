using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
        if (collision.gameObject.tag == "Boss")
        {
            GameObject.FindWithTag("Boss").SendMessage("bossHealthDecrease");
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "BossBullet")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
