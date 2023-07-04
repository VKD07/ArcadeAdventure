using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] BulletDirection direction;
    [SerializeField] PlayerControlsData playerControlsData;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }

    private void ShootBullet()
    {
        if (Input.GetKeyDown(playerControlsData.BombKey))
        {
            Vector3 pos = transform.position;
            GameObject bulletObj = Instantiate(bulletPrefab, pos, Quaternion.identity);
            bulletObj.GetComponent<Rigidbody2D>().velocity = direction.GetBulletDirection() * bulletSpeed;
        }
    }
}
