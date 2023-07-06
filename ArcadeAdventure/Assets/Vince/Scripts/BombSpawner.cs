using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] PlayerControlsData playerControlsData;
    [SerializeField] ObjectPooling objectPooling;
    [SerializeField] Transform parent;

    // Update is called once per frame

    private void Start()
    {
        objectPooling.SetParent(parent);
        objectPooling.InitObjects();
    }
    void Update()
    {
        SpawnBomb();
    }

    private void SpawnBomb()
    {
        if (Input.GetKeyDown(playerControlsData.BombKey))
        {
            Vector3 bombPos = new Vector3(transform.position.x, transform.position.y, -6.395f);
            objectPooling.SpawnObject(bombPos);
        }
    }

    private void OnDisable()
    {
        objectPooling.objects.Clear();
    }
}
