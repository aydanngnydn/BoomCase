using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{   
    public PlayerManager playerscript;
    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !playerscript.isdead)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
        
    }


}