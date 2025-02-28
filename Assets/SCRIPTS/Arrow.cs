using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;

    void Start()
    {
        Destroy(gameObject, 1f);
    }
    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }
}
