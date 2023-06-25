using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    //var gameobjec  Gameobjectt;

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

    void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
    }
}
