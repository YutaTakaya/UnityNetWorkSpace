using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorol : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.AddForce(x, 0, z);
    }
}
