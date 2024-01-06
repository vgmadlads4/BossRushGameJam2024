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
            this.GetComponent<Transform>().position = new Vector2(this.GetComponent<Transform>().position.x + 0.1f, this.GetComponent<Transform>().position.y);
        }
        if (Input.GetKey("a"))
        {
            this.GetComponent<Transform>().position = new Vector2(this.GetComponent<Transform>().position.x - 0.1f, this.GetComponent<Transform>().position.y);
        }
        if (Input.GetKeyDown("space") && GetComponent<CharacterController>().isGrounded)
        {
            this.GetComponent<Rigidbody2D>().transform.position = new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y + 0.1f);
        }
    }
}
