using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float TimeSpawn;
    public GameObject EnemySpawn;
    private float BaseTime;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        BaseTime = TimeSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpawn -= Time.deltaTime;
        if(TimeSpawn <= 0)
        {
            Instantiate(EnemySpawn, transform.position, Quaternion.identity);
            TimeSpawn = BaseTime;
        }


    }
}
