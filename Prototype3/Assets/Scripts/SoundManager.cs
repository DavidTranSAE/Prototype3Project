using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.playDiary += PlaySound;
        Diary.pageTurn += PlaySound;
    }

    private void OnDisable()
    {
        Player.playDiary -= PlaySound;
        Diary.pageTurn -= PlaySound;
    }

    void PlaySound(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.Play();
        Debug.Log("Play");
    }
}
