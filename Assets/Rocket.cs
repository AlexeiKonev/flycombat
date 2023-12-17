using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 3f;
    [SerializeField]private int damageForce = 2;
    [SerializeField]private Vector3 moveVector = Vector3.up  ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate( moveVector,Space.World);
    }
}
