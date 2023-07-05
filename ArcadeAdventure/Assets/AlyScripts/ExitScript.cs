using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public int iLevelToLoad;
    public bool useIntegerToLoadLevel;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
