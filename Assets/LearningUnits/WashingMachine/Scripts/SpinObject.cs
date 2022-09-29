using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{

    Rigidbody rigidbody;
    [SerializeField] Vector3 EulerAngleVelocity;

    // Start is called before the first frame update
    void Start()
    {
        // needed to declare rigidbody
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(EulerAngleVelocity);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
    }
}
