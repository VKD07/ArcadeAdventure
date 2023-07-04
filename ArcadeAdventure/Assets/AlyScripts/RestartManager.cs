using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    

    public int iLevelToLoad;
    public bool useIntegerToLoadLevel;
    public Transform ballStart;
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.tag == "DeathCollider")
        {
            //Invoke("LoadScene", 0.0001f);
            transform.position = ballStart.transform.position;

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Invoke("LoadScene", 0.0001f);

        }
    }

    void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
    }
}
