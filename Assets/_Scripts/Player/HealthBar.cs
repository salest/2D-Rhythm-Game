using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Player player;
    private float currentHealth;
    private float maxHealth;
    private Image healthbar;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
        player =FindObjectOfType<Player>();
        maxHealth = player.maxHealth;
        currentHealth = player.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = player.currentHealth;
        if (currentHealth == 0) 
        {
            healthbar.fillAmount = 0;
        } 
        else
        {
            healthbar.fillAmount = currentHealth / maxHealth;
        }
        
    }
}
