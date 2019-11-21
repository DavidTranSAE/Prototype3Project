using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private void OnEnable()
    {
        Diary.playDiary += PlaySound;
        Door.doorOpen += PlaySound;
        Door.doorClose += PlaySound;
        Door.doorLocked += PlaySound;
    }

    private void OnDisable()
    {
        Diary.playDiary -= PlaySound;
        Door.doorOpen -= PlaySound;
        Door.doorClose -= PlaySound;
        Door.doorLocked -= PlaySound;
    }

    void PlaySound(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
}
