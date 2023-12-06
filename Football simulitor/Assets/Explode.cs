using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Explode : MonoBehaviour
{
    float timer = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            explode();
        }
    }

    private void explode()
    {
        Collider[] victims = Physics.OverlapSphere(transform.position, 10);

        foreach (Collider victim in victims)
        {
            Rigidbody rb_victim = victim.GetComponent<Rigidbody>();
            if (rb_victim != null)
                rb_victim.AddExplosionForce(2000, transform.position, 10);
        }
    }
}
