using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image crosshair;

    public Sprite dot;
    public Sprite circle;

    public GameObject player;
    public Image healthBar;

    void Update()
    {
        //if player is hovering over something that is interactable, change crosshair
        if (player.GetComponent<Player>().canInteract)
        {
            crosshair.sprite = circle;
        }
        else
        {
            crosshair.sprite = dot;
        }

        float fill = player.GetComponent<Player>().health / player.GetComponent<Player>().maxHealth;
        healthBar.fillAmount = fill;



    }






}
