using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ObjectPooling : ScriptableObject
{
    public GameObject bombPrefab;
    public List<GameObject> objects;
    public int numberOfObjectsToSpawn = 5;
    public Transform parent;

    public void InitObjects()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            GameObject bombObj = Instantiate(bombPrefab, Vector3.one, Quaternion.identity);
            AddToPool(bombObj);
            bombObj.SetActive(false);
            bombObj.transform.SetParent(parent);
        }
    }

    public void SetParent(Transform parentTransform)
    {
        parent = parentTransform;   
    }

    public void SpawnObject(Vector3 spawnLocation)
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if (!objects[i].activeSelf)
            {
                objects[i].SetActive(true);
                objects[i].transform.position = spawnLocation;
                break;
            }
        }
    }

    public void AddToPool(GameObject obj)
    {
        objects.Add(obj);
    }
}
