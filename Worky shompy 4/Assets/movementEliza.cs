using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementEliza : MonoBehaviour
{

    // Adjust the speed for the application.
    public float speed = 5.0f;

    // The target (cylinder) position.
    public Transform target;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move

        if (Vector3.Distance(transform.position, target.position) < 5.001f)
        {

            if (Vector3.Distance(transform.position, target.position) > 1.001f)
            {
                // Swap the position of the cylinder.
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            }
        }


        Vector3 targetDirection = target.position - transform.position;

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
