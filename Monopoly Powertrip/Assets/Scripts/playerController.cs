using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
<<<<<<< HEAD
 //HEAD
    public int health = 3;

=======
    public int health = 3;
>>>>>>> Fixing_More_Issues
    public playerController thePlayer;
    public GameObject playerCharacter;
    public int getBulletType;

    private void Awake()
    {

    }
<<<<<<< HEAD

=======
>>>>>>> Fixing_More_Issues
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
