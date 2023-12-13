using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class BomberGuyScript : MonoBehaviour
{
   
    private float rotSpeed = 360;
    private float currentSpeed = 3; 

    public GameObject bombCLoneTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(bombCLoneTemplate, transform.position, transform.rotation);
           
    }
}
