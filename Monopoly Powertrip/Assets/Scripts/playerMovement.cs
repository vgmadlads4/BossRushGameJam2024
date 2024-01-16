using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            this.GetComponent<Transform>().Translate(Vector2.right * 0.01f);
            this.GetComponent<Transform>().Rotate(new Vector2(0, 0));

        }
        if (Input.GetKey("a"))
        {
            this.GetComponent<Transform>().Translate(Vector2.left * 0.01f);
            this.GetComponent<Transform>().Rotate(new Vector2(180, 0));
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey("space")  && (collision.name == "jumpPad"))
        {
            this.GetComponent<Rigidbody2D>().velocity = (Vector2.up * 6f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Boss")
        {
            GameObject.Find("playerTrack").SendMessage("removeAHealthPoint");
        }
    }
}
