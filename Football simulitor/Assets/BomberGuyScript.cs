using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class BomberGuyScript : MonoBehaviour
{
    public GameObject bombCLoneTemplate;
    private float rotSpeed = 360;
    private float currentSpeed = 3; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
               transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(bombCLoneTemplate, transform.position, transform.rotation);
           
    }
}
