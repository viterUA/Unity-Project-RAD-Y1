using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{
    Rigidbody rb;
    Vector3 velocity, acceleration;
    float rateOfRotation = 180f;
    public float normalSpeed = 25f;
    public float accelerationSpeed = 45f;
    public float rotationSpeed = 2.0f;
    float rotation = 0;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }



    // Update is called once per frame
    void Update()
    {
        acceleration = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        { rb.AddForce( transform.forward ); }

        if (Input.GetKey(KeyCode.S))
        { rb.AddForce(-transform.forward); }

        if (Input.GetKey(KeyCode.A))
        {
            rotation = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotation = 1;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Rotate(Vector3.right, rateOfRotation * Time.deltaTime); }

        if (Input.GetKey(KeyCode.DownArrow))
        { transform.Rotate(Vector3.left, rateOfRotation * Time.deltaTime); }

        if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Rotate(Vector3.forward, rateOfRotation * Time.deltaTime); }

        if (Input.GetKey(KeyCode.RightArrow))
        { transform.Rotate(Vector3.back, rateOfRotation * Time.deltaTime); }

    }
}
