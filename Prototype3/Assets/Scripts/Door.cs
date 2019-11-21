using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    AudioSource mySource;
    public AudioClip doorOpenClip;
    public AudioClip doorCloseClip;
    public AudioClip doorLockedClip;

    public delegate void DoorSound(AudioSource source, AudioClip clip);
    public static DoorSound doorOpen;
    public static DoorSound doorClose;
    public static DoorSound doorLocked;

    public bool isLocked;
    public bool isOpen;

    float closedRot; //the y Euler angle of the door in its closed state
    float openRot; //the y Euler angle of the door in its open state
    float rotSpeed;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
        closedRot = transform.rotation.eulerAngles.y;
        openRot = closedRot - 90f;
        rotSpeed = 2f;
    }

    // automatically opens or closes the door depending on the isOpen bool
    void Update()
    {
        if (isOpen && transform.rotation.eulerAngles.y > openRot)
        {
            transform.Rotate(Vector3.up, -rotSpeed);
        }
        else if (!isOpen && transform.rotation.eulerAngles.y < closedRot)
        {
            transform.Rotate(Vector3.up, rotSpeed);
        }
    }

    public void Clicked()
    {
        if (!isLocked)
        {
            if (isOpen)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
        else
        {
            doorLocked(mySource, doorLockedClip);
        }
    }

    public void Open()
    {
        isOpen = true;
        doorOpen(mySource, doorOpenClip);
    }

    public void Close()
    {
        isOpen = false;
        doorClose(mySource, doorCloseClip);
    }

    public void Lock()
    {
        isLocked = true;
        doorLocked(mySource, doorLockedClip);
    }

    public void Unlock()
    {
        isLocked = false;
        doorLocked(mySource, doorLockedClip);
    }
}
