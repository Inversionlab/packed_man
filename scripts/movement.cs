using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb; 
    Vector2 movements;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movements.x=Input.GetAxisRaw("Horizontal");
        movements.y=Input.GetAxisRaw("Vertical");

        
    }
    void FixedUpdate() {
        rb.MovePosition(rb.position + movements *Time.deltaTime* movespeed);

        
    }
}
