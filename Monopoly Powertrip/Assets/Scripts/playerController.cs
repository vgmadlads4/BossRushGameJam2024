using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
<<<<<<< Updated upstream
    public int health = 100;
=======
    public playerController thePlayer;
    public int health = 3;
    public int getBulletType;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {

        }
    }
}
