using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    float timeLeft = 5;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            timeLeft = 5;
            var enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;
        }
    }
}
