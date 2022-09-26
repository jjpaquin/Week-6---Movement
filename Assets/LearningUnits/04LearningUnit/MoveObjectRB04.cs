using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB04 : MonoBehaviour
{
    // For Unit 3: I changed the Mass of the blue cube so that the red cube was able to move it with the given force.
    // For Unit 4: I changed the Mass of the red cube so that the force applied would be enough to move the red cube. It leaves the red cube on the stage as well.

    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(-2400, 0,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();

        // Don't move this line or add any new values (such as coefficients)!
        rigidbody.AddForce(moveDirection, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
