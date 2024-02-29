using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{
    private int speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void baba()
    {
        Vector3 movement = transform.forward;
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
