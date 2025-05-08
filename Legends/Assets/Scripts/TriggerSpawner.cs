using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : Spawner
{
    public override void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartSpawn();
        }
    }
}
