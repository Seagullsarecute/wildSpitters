using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        rb.velocity = new Vector3(0,14f,0);
    }
}
