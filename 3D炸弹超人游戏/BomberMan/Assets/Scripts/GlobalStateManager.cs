using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlobalStateManager : MonoBehaviour
{
    private int deadPlayers = 0;
    private int deadPlayerNumber = -1;
    public GameObject GO;
    public GUIText guit;


    public void PlayerDied (int playerNumber)
    {
        deadPlayers++; 

        if (deadPlayers == 1)
        { 
            deadPlayerNumber = playerNumber;
            CheckPlayersDeath();
        }
    }

    void CheckPlayersDeath()
    {
        if (deadPlayers == 1)
        {
            if (deadPlayerNumber == 1)
            {
                Application.LoadLevel("Stage2");
            }
            if (deadPlayerNumber == 2)
            {
                Application.LoadLevel("Stage3");
            }
        }
    }

}

