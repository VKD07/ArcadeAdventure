using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] public GameObject destinationPointPrefab;
    [SerializeField] public List<GameObject> destinations;
    [SerializeField] public Transform spawnPosition;
    [SerializeField] int currentIndex;

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        Vector3 targetPosition = destinations[currentIndex].transform.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementSpeed);

        if (transform.position == targetPosition)
        {
            currentIndex++;

            if (currentIndex >= destinations.Count)
            {
                currentIndex = 0;
            }
        }
    }

    public void AddDestination(GameObject destination)
    {
        destinations.Add(destination);
    }

    public void ResetDestinations()
    {
        for (int i = 0; i < destinations.Count; i++)
        {
            DestroyImmediate(destinations[i]);
        }
        destinations.Clear();
    }
}
