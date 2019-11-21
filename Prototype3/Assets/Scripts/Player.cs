using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void MoveRoom();
    public static MoveRoom circusCol;
    public static MoveRoom bedroom2Col;
    public static MoveRoom buildingCol;

    public delegate void DiaryEntry(AudioSource source, AudioClip clip);
    public static DiaryEntry playDiary;

    public GameObject camera;

    public bool interactable;


    AudioSource myAudio;

    public AudioClip diaryClip1;
    public AudioClip diaryClip2;
    public AudioClip diaryClip3;



    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
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
        if (Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 1.5f))
        {
            if (hit.transform.tag == "Interactable")
            {
                interactable = true;
            }
            else
            {
                interactable = false;
            }
        }
        else
        {
            interactable = false;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (interactable)
            {
                InteractClick(hit.transform.gameObject);
            }
        }
    }

    void InteractClick(GameObject hitObject)
    {
        if (hitObject.name == "Diary")
        {
            playDiary(myAudio, diaryClip1);
            hitObject.GetComponent<Diary>().Clicked();
        }
    }

}
