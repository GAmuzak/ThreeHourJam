using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (GetComponent<Collider>().isTrigger.Equals(CompareTag("Bullet")))
        {
            Destroy(gameObject);
        }

        Vector3 playerPosition = player.gameObject.transform.position;
        rb.velocity=(playerPosition - transform.position) * speed;
    }
}
