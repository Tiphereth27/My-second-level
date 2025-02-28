using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Backgorund : MonoBehaviour
{
    private float moveSpeed = 3f;
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if(transform.position.y < -11)
        {
            transform.position += new Vector3(0, 22f, 0);
        }
    }
}
