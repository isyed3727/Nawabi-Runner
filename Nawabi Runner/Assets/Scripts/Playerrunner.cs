using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerrunner : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, 10);
        
    }
}