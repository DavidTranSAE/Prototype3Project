using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour
{
    AudioSource mySource;
    public AudioClip diaryClip;

    public delegate void DiaryEntry(AudioSource source, AudioClip clip);
    public static DiaryEntry playDiary;

    public GameObject door;
    bool clicked;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    public void Clicked()
    {
        playDiary(mySource, diaryClip);

        if (!clicked)
        {
            clicked = true;
            StartCoroutine(DoorTrigger());
        }
    }

    IEnumerator DoorTrigger()
    {
        yield return new WaitForSeconds(diaryClip.length + 0.5f);
        door.GetComponent<Door>().Unlock();
        door.GetComponent<Door>().Open();
    }
}
