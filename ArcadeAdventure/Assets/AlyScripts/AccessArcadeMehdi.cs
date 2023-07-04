using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccessArcadeMehdi : MonoBehaviour
{
     public GameObject OpenPanel = null;

    public int iLevelToLoad;
    public bool useIntegerToLoadLevel;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
    {
        OpenPanel.SetActive(true);

    }
    
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
    }
    
    private bool isOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }
 
    
    void Update()
    {
        if (isOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                OpenPanel.SetActive(false);
                 Invoke("LoadScene", 0.0001f);
            }
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
