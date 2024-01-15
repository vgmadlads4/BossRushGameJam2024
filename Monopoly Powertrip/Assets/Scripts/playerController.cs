using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< Updated upstream
<<<<<<< HEAD
<<<<<<< HEAD
 //HEAD
=======
=======
>>>>>>> Stashed changes
>>>>>>> Merge_Issues_Fix_1_14_2024
    public int health = 3;

=======
    public int health = 3;
>>>>>>> Fixing_More_Issues
=======
>>>>>>> Boss-Moving-back-and-forth-first-stage-1_15_2024
    public playerController thePlayer;
    public GameObject playerCharacter;
    public int getBulletType;

    private void Awake()
    {

    }
<<<<<<< HEAD

<<<<<<< HEAD
=======
>>>>>>> Fixing_More_Issues
=======
>>>>>>> Boss-Moving-back-and-forth-first-stage-1_15_2024
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
