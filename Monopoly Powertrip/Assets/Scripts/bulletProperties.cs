using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletProperties : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().Translate(Vector2.right * Time.deltaTime);
    }
}
