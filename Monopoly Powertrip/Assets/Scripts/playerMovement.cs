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
        }
        if (Input.GetKey("a"))
        {
            this.GetComponent<Transform>().Translate(Vector2.left * 0.01f);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey("space"))
        {
            this.GetComponent<Rigidbody2D>().velocity = (Vector2.up * 5f);
        }
    }
}
