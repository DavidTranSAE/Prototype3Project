using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void MoveRoom();
    public static MoveRoom circusCol;
    public static MoveRoom bedroom2Col;
    public static MoveRoom buildingCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "CircusCol")
        {
            circusCol();
        }

        if (other.name == "Bedroom2Col")
        {
            bedroom2Col();
        }

        if (other.name == "BuildingCol")
        {
            buildingCol();
        }
    }
}
