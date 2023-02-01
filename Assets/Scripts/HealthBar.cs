using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Player player;
    private const float MAX_HEALTH = 100f;
    private Image healthBar;
    
    
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.hp);
        healthBar.fillAmount = player.hp / MAX_HEALTH;
        Debug.Log(healthBar.fillAmount);

    }
}
