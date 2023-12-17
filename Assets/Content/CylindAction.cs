using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CylindAction : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        DoJump();
        {
        }

       

    }
    public void DoJump()
        {
            rb.AddForce(Vector3.up * 10f * Time.deltaTime);
        }
}
