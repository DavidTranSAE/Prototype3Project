using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void MoveRoom();
    public static MoveRoom circusCol;
    public static MoveRoom bedroom2Col;
    public static MoveRoom buildingCol;

    public GameObject camera;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InteractCheck();
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

    void InteractCheck()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 1f))
        {
            Debug.Log("First Hit");
            Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "Interactable")
            {
                Debug.Log("hit");
            }
        }
    }
}
