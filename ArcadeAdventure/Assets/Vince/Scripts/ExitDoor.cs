using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] ListOfEnemies listOfEnemies;
    [SerializeField] float detectionRange = 5f;
    [SerializeField] LayerMask playerLayer;
    [SerializeField] string sceneNameToLoad;
    SpriteRenderer spriteRenderer;
    bool sceneLoaded;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
    void Update()
    {
        ShowDoor();
    }
    private void ShowDoor()
    {
        if (listOfEnemies.enemies.Count <= 0)
        {
            spriteRenderer.enabled = true;
            EndLevel();
        }
    }

    private void EndLevel()
    {
        if (Physics2D.OverlapCircle(transform.position, detectionRange, playerLayer))
        {
            if(sceneNameToLoad != null)
            {
                SceneManager.LoadScene(sceneNameToLoad);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
