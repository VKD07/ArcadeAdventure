using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToList : MonoBehaviour
{
    [SerializeField] ListOfEnemies listOfEnemies;

    void Start()
    {
        listOfEnemies.AddEnemy(gameObject);
    }

    private void OnDestroy()
    {
        listOfEnemies.RemoveEnemy(gameObject);
    }
}
