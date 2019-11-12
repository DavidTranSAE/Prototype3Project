using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManager : MonoBehaviour
{
    public GameObject bedroom1;
    public GameObject bedroom2;
    public GameObject tent;

    private void OnEnable()
    {
        Player.moveRoom1 += moveRoom1;
        
    }

    private void OnDisable()
    {
        Player.moveRoom1 -= moveRoom1;
    }



    void moveRoom1()
    {
        Destroy(bedroom1.gameObject);
        bedroom2.transform.position = Vector3.zero;
    }

    void moveRoom2()
    {

    }
}
