using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempWinScript : MonoBehaviour
{
    //TEMPORARY
    //This is a temp script that opens the door after being triggered by an entering player. This calls the win event which the GameManager picks up opens the hallway door. This should ideally happen after defeating the boss/challenge.
    public delegate void Win();
    public static Win win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            win();
        }
    }
}
