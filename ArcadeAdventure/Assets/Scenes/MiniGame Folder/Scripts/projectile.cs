using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectfilePrefab;

    public float moveSpeed;
    private pointManager pointManager;
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<pointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            pointManager.UpdateScore(10);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag =="Boundary")
        {
            Destroy(gameObject);
        }
    }
}
