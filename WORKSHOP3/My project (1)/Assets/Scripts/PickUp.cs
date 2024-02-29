using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickupItem")
        {
            Debug.Log("Entered collision with " + other.gameObject.name);
            other.gameObject.SetActive(false);
            // set state player to PowerUpped.
        }
    }
}
