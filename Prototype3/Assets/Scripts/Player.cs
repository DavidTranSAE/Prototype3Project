using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //This reference is so that the Raycast from the play happens from the camera's position rather than the player's
    public GameObject camera;

    //this is to track if an interactable object is being moused over
    public bool canInteract;

    AudioSource myAudio;
    public float health, maxHealth;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        InteractCheck();
    }

    //checks if what the player is looking at can be interacted with and then changes a bool accordingly
    //this is needed to tell the UIManager to change crosshair modes.
    void InteractCheck()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 1.5f))
        {
            if (hit.transform.tag == "Interactable")
            {
                canInteract = true;
            }
            else
            {
                canInteract = false;
            }
        }
        else
        {
            canInteract = false;
        }

        //if the player clicks on something that can be interacted with
        if (Input.GetMouseButtonUp(0))
        {
            if (canInteract)
            {
                InteractClick(hit.transform.gameObject);
            }
        }
    }

    void InteractClick(GameObject hitObject)
    {
        //after being clicked, calls the clicked function of that object
        if (hitObject.GetComponent<Diary>() != null)
        {
            hitObject.GetComponent<Diary>().Clicked();
        }

        if (hitObject.GetComponent<Door>() != null)
        {
            hitObject.GetComponent<Door>().Clicked();
        }
    }

}
