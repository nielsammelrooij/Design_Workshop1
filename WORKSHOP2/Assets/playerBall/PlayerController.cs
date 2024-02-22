using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    public float jumpStrength = 200.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void OnFire()
    {
        Vector3 jump = new Vector3(0.0f, jumpStrength, 0.0f);
        GetComponent<Rigidbody>().AddForce(jump);
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            jumpStrength += 400.0f;
            transform.localScale += new Vector3(1, 1, 1);
        }
        if (other.gameObject.CompareTag("Boom"))
        {
            other.gameObject.SetActive(false);
            Vector3 boom = new Vector3(0.0f, 10000.0f, 10000.0f);
            GetComponent<Rigidbody>().AddForce(boom);
        }
    }
}
