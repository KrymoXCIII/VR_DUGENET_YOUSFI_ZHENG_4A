using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(int damage)
    {
        hp -= damage;
       
        if (hp <= 0) Invoke(nameof(Dead),.5f);
    }

    
    private void Dead()
    {
        Debug.Log("DEAD!!");
    }
    
    
}
