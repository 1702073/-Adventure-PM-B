using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 2;
    public int maxHealth = 2;
    public Image healthImage;

    public Sprite hearts0;
    public Sprite hearts1;
    public Sprite hearts2;

    void Start()
    {

    }


    void Update()
    {
        if (playerHealth > maxHealth)
        {
            playerHealth = maxHealth;
        }
        if (playerHealth == 2)
        {
            healthImage.sprite = hearts2;
            Debug.Log("Life2");
        }
        if (playerHealth <= 1)
        {
            healthImage.sprite = hearts1;
            Debug.Log("Life1");
        }
        if (playerHealth <= 0)
        {
            healthImage.sprite = hearts0;
            Debug.Log("Life0");
        }
       
    }
}
