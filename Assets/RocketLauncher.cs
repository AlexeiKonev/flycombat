// RocketLauncher.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public GameObject rocketPrefab;

    void Start()
    {
        // Initialization if needed
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            Debug.Log("Launch");
            LaunchRocket();
        }
    }

    public void LaunchRocket()
    {
        GameObject newRocket = Instantiate(rocketPrefab, transform.position, Quaternion.identity);

        // Get the rotation of the launcher
        Quaternion launcherRotation = transform.rotation;

        // Apply an offset to the rocket's rotation based on the launcher's rotation
        newRocket.transform.rotation = launcherRotation;

        // Access the Rocket script on the instantiated rocket and set its moveVector to match the launcher's rotation
        Rocket rocketScript = newRocket.GetComponent<Rocket>();
        if (rocketScript != null)
        {
            rocketScript.SetMoveVector(launcherRotation * Vector3.up);
        }
    }
}
