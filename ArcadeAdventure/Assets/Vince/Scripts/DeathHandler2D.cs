using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler2D : MonoBehaviour
{
    [SerializeField] float horizontalMinLimit;
    [SerializeField] float horizMaxLimit;
    [SerializeField] float verticalMinLimit;
    [SerializeField] float verticalMaxLimit;

    private void Update()
    {
        CheckPlayerPos();
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void CheckPlayerPos()
    {
        if (transform.localPosition.x > horizontalMinLimit || transform.localPosition.x < horizMaxLimit
            || transform.localPosition.y < verticalMinLimit || transform.localPosition.y > verticalMaxLimit)
        {
            Destroy(gameObject);
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Deadly")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
