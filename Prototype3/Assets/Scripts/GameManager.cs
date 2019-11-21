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

    int diaryInt = 1;

    private void OnEnable()
    {
        Player.circusCol += Movebedroom2;
        Player.bedroom2Col += MoveBuilding;
        Player.buildingCol += MoveBedroom3;
    }

    private void OnDisable()
    {
        Player.circusCol -= Movebedroom2;
        Player.bedroom2Col -= MoveBuilding;
        Player.buildingCol -= MoveBedroom3;
    }

    void Movebedroom2()
    {
        Destroy(bedroom1.gameObject);
        bedroom2.transform.position = Vector3.zero;

        diaryInt++;
    }

    void MoveBuilding()
    {
        Destroy(circus.gameObject);
        building.transform.position = Vector3.zero;
    }

    void MoveBedroom3()
    {
        Destroy(bedroom2.gameObject);
        bedroom3.transform.position = Vector3.zero;
        diaryInt++;
    }

    void DiaryEntry()
    {
        if (diaryInt == 1)
        {
            Debug.Log("First Entry");
        }
        else if (diaryInt == 2)
        {
            Debug.Log("Second Entry");
        }
        else if (diaryInt == 3)
        {
            Debug.Log("Third Entry");
        }
    }
}
