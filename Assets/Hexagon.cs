﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public GameObject hexagon;
    public Rigidbody2D rb;
    public float shrinkSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if(transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }
    }
}
