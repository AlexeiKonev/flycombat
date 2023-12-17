using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public GameObject rocket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) )
        {
            Debug.Log("launch");
            LaunchRocket();
        }
    }
    public  void LaunchRocket()
    {
           Instantiate (rocket,transform.position, rocket.transform.rotation);
    }
  
}
