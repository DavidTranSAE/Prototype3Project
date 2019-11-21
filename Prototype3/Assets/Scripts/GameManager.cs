using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bedroom1;
    public GameObject bedroom2;
    public GameObject bedroom3;

    public GameObject circus;
    public GameObject building;
    public GameObject final;

    public GameObject door;

    private void OnEnable()
    {
        Checkpoint.giveCheckpoint += CheckpointUpdate;
        TempWinScript.win += Win;
    }

    private void OnDisable()
    {
        Checkpoint.giveCheckpoint -= CheckpointUpdate;
        TempWinScript.win -= Win;
    }

    void CheckpointUpdate(string checkpoint)
    {
        if (checkpoint == "circus")
        {
            Destroy(bedroom1.gameObject);
            bedroom2.transform.position = Vector3.zero;
        }

        if (checkpoint == "bedroom2")
        {
            Destroy(circus.gameObject);
            building.transform.position = Vector3.zero;
        }

        if (checkpoint == "building")
        {
            Destroy(bedroom2.gameObject);
            bedroom3.transform.position = Vector3.zero;
        }

        if (checkpoint == "bedroom3")
        {
            Destroy(building.gameObject);
            final.transform.position = Vector3.zero;
        }

        if (checkpoint == "final")
        {
            GameWin();
        }
    }

    void Win()
    {
        door.GetComponent<Door>().Open();
    }

    void GameWin()
    {

    }
}
