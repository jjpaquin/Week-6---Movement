using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB02 : MonoBehaviour
{
    // I also needed to increase the move direction so that the cube would move

    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        // needed to declare rigidbody
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Force);
    }
}
