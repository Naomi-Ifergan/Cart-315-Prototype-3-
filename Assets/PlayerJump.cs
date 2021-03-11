using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public float jumpForce = 300.0f;
    private void FixedUpdate()
    {
        bool jump = Input.GetButtonDown ("Jump");
        if (jump) GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
    }
}
