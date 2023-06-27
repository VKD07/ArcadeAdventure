using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArcadeBtns : MonoBehaviour
{
    [SerializeField] UnityEvent OnButtonPressed;
    [SerializeField] UnityEvent OnButtonReleased;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            OnButtonPressed.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OnButtonReleased.Invoke();
        }
    }
}
