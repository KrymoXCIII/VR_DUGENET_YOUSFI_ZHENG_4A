using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        Debug.Log(hp);
        TakeDamage(10);
        
    }
}
