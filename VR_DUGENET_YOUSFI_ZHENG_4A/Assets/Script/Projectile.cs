using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    protected Weapon weapon;

    public virtual void Init(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public virtual void Launch()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyManager Enemy = collision.gameObject.GetComponent(typeof(EnemyManager)) as EnemyManager;
            
            if (Enemy != null)
            {
                Enemy.PV -= 20;
                weapon.player.Score += 10;
                if (Enemy.PV <= 0)
                {
                    Destroy(Enemy.gameObject);
                    weapon.player.Score += 50;
                }

                weapon.player.TextScore.text = weapon.player.Score.ToString();

            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            PlayerManager Player = collision.gameObject.GetComponent(typeof(PlayerManager)) as PlayerManager;
            if (Player != null)
            {
                Player.PV -= 10;
                if (Player.PV <= 0)
                {
                    Time.timeScale = 0;
                    Time.fixedDeltaTime = 0;
                }
            }
        }
    }
    

}
