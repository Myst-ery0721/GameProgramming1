using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullets;
    public Transform BulletSpawn;
    public float bulletSpeed;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnBullets), timer, timer);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullets();
        }
        
    }
    public void SpawnBullets()
    {
        
            GameObject _bullets = Instantiate(bullets, BulletSpawn.position, BulletSpawn.rotation);
            Rigidbody rb = _bullets.GetComponent<Rigidbody>();
            rb.velocity = BulletSpawn.forward * bulletSpeed;
        Destroy(_bullets, 5);
        
    }
}
