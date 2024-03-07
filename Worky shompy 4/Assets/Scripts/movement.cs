using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float movementSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("W key was pressed");
            Rigidbody.velocity = transform.forward * movementSpeed;
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("S key was pressed");
            Rigidbody.velocity = -transform.forward * movementSpeed;
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("D key was pressed");
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * (10 * rotationSpeed), Space.World);
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("A key was pressed");
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * (10 * rotationSpeed), Space.World);
        }

    }
}
