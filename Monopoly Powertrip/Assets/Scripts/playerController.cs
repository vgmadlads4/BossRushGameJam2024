using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
<<<<<<< HEAD
    public int health = 3;
=======
    public playerController thePlayer;
    public GameObject playerCharacter;
    public int health = 3;
    public int getBulletType;

    private void Awake()
    {

    }

>>>>>>> Shooting_Script_1_11_2024
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
