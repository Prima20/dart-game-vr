using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        MoveBackward();
    }

    private void MoveForward()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * movementSpeed * Time.deltaTime;
        }
    }

    private void MoveBackward(){
        if (Input.GetButton("Fire2"))
        {
            transform.position = transform.position + -Camera.main.transform.forward * movementSpeed * Time.deltaTime;
        }
    }
}
