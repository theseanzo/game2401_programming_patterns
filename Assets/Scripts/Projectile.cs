using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }
    // Update is called once per frame
    public void Shoot(Vector3 direction, float force)
    {
        rb?.AddRelativeForce(direction * force);
    }
}
