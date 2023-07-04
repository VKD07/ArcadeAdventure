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
        if(listOfEnemies.enemies.Count <= 0) {
            spriteRenderer.enabled = true;
            EndLevel();
        }
    }

    private void EndLevel()
    {
        if (Physics2D.OverlapCircle(transform.position, detectionRange, playerLayer))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRange, playerLayer);

            foreach (Collider2D collider in colliders)
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
