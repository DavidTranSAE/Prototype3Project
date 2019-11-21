using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //this script gives signals to the GameManager when a player triggers a collision box at a particular point in the game. 

    
    public string checkpoint; //the value of the checkpoint is manually entered via the inspector
    bool check; //a check to make sure this only happens once
    public GameObject door; //a reference to a door that closes once this checkpoint is triggered

    //event
    public delegate void CheckpointTrigger(string checkpoint);
    public static CheckpointTrigger giveCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (!check && other.GetComponent<Player>() != null)
        {
            check = true;

            door.GetComponent<Door>().Lock();
            door.GetComponent<Door>().Close();

            StartCoroutine(UpdateCheckpoint());
        }
    }

    IEnumerator UpdateCheckpoint()
    {
        yield return new WaitForSeconds(3);
        giveCheckpoint(checkpoint);
        Destroy(gameObject);
    }
}
