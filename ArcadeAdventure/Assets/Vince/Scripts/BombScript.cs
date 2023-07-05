using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BombScript : MonoBehaviour
{
    [SerializeField] BombData bombData;
    [SerializeField] Animator bombCircleAnim;
    [SerializeField] UnityEvent OnExplosion;
    // Update is called once per frame
    private void OnEnable()
    {
        StartCountdown();
    }

    private void Update()
    {
        bombCircleAnim.speed += 1.1f * Time.deltaTime;
    }

    private void StartCountdown()
    {
        StartCoroutine(DisableBomb());
    }

    private void OnDisable()
    {
        bombCircleAnim.speed = 1f;
        if (Physics2D.OverlapCircle(transform.position, bombData.bombRange, bombData.layerAffected))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, bombData.bombRange, bombData.layerAffected);

            foreach (Collider2D collider in colliders)
            {
                Destroy(collider.gameObject);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, bombData.bombRange);
    }

    IEnumerator DisableBomb()
    {
        yield return new WaitForSeconds(bombData.bombCountdown);
        OnExplosion.Invoke();
        ShakeCamera.Instance.TriggerCameraShake();
        gameObject.SetActive(false);
    }
}
