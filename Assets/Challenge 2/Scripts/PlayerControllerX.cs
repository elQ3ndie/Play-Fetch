using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    //The number of dogs that can be spawned in a second is 2
    private float dogSpawnTime = 0.5f;
    private float timestamp;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time >= timestamp && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timestamp = Time.time + dogSpawnTime;
        }
    }
    
}
