using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathHandler : MonoBehaviour
{
    [SerializeField] GameObject explosionVFX;
    private void OnDestroy()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, -5.64f);
        GameObject vfx = Instantiate(explosionVFX, spawnPos, Quaternion.identity);
        Destroy(vfx, 1);
    }
}
