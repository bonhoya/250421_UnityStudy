using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell0421 : MonoBehaviour
{
    [SerializeField] Rigidbody shellRigid;
    [SerializeField] GameObject explosionEffect;

    private void Update()
    {
        if(shellRigid.velocity.magnitude > 0)
        {
            transform.forward = shellRigid.velocity;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(explosionEffect, transform.position, transform.rotation);
    }
}
