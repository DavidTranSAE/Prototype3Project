﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image crosshair;

    public Sprite dot;
    public Sprite circle;

    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Player>().interactable)
        {
            crosshair.sprite = circle;
        }
        else
        {
            crosshair.sprite = dot;
        }
    }
}
