using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTracker : MonoBehaviour
{
    public int health = 3;
    public GameObject playerModel;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            Instantiate(playerModel, GameObject.Find("playerSpawner").GetComponent<Transform>().position, GameObject.Find("playerSpawner").GetComponent<Transform>().rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeAHealthPoint()
    {
<<<<<<< HEAD
        print("Hi");
=======
>>>>>>> Second_Stage_Of_The_First_Boss_1_16_2024
        health = -1;
    }
}
