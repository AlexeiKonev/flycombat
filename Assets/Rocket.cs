// Rocket.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private int damageForce = 2;
    private Vector3 moveVector;

    void Start()
    {
        moveVector = Vector3.up;
    }

    void FixedUpdate()
    {
        transform.Translate(moveVector * moveSpeed * Time.fixedDeltaTime, Space.World);
    }

    public void SetMoveVector(Vector3 newMoveVector)
    {
        moveVector = newMoveVector;
    }
}
