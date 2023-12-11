using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJoystick : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private FixedJoystick fixedJoystick;
    private Rigidbody rigidBody;

    private void OnEnable()
    {
        fixedJoystick= FindObjectOfType<fixedJoystick>();
        rigidBody = gameObject.GetComponent<rigidBody>();

    }

    private void FixedUpadate()
    {
        float xval = fixedJoystick.Horizontal;
        float yval = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xval, 0, yval);
        rigidBody.velocity =movement * speed;

        if (xval !=0 && yval !=0)
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xval,yval)*Mathf.Rad2Deg, transform.eulerAngles.z);

    }
}
