using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour
{
    AudioSource mySource;
    public AudioClip pageClip;

    public delegate void DiarySound(AudioSource source, AudioClip clip);
    public static DiarySound pageTurn;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        pageTurn(mySource, pageClip);
    }
}
