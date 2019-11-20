using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManager : MonoBehaviour
{
    public GameObject bedroom1;
    public GameObject bedroom2;
    public GameObject bedroom3;

    public GameObject circus;
    public GameObject building;

    private void OnEnable()
    {
        Player.circusCol += movebedroom2;
        Player.bedroom2Col += moveBuilding;
        Player.buildingCol += moveBedroom3;

    }

    private void OnDisable()
    {
        Player.circusCol -= movebedroom2;
        Player.bedroom2Col -= moveBuilding;
        Player.buildingCol -= moveBedroom3;
    }

    void movebedroom2()
    {
        Destroy(bedroom1.gameObject);
        bedroom2.transform.position = Vector3.zero;
    }

    void moveBuilding()
    {
        Destroy(circus.gameObject);
        building.transform.position = Vector3.zero;
    }

    void moveBedroom3()
    {
        Destroy(bedroom2.gameObject);
        bedroom3.transform.position = Vector3.zero;
    }
}
