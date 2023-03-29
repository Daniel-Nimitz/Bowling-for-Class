using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionFive : MonoBehaviour
{
    [SerializeField] int playerHealth = 5;
    [SerializeField] bool isPlayerDead = true;
    public bool hasGameStarted = true;
    // Start is called before the first frame update
    void Start()
    {
        if (playerHealth > 0 && hasGameStarted)
        {
            Debug.Log("Player is Alive");

        }
        else if (playerHealth >0) {
            Debug.Log("Player Alive but Game Not Started");
        
        }
        else{ 
        Debug.Log("Game is dead!  Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
