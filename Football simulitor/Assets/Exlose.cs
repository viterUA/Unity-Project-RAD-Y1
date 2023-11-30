using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exlose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Exlose();
        }

    }

    private void Exlose()
    {
        Collider[] victims = Physics.OverlapSphere(transform.position, 10);

        foreach(Collider victim in victims)
        {
           Rigidbody rb_victim = victim.GetComponent<Rigidbody>();
            rb_victim.AddExplosionForce(2000,transform.position, 10);
        }
    }
    
}
