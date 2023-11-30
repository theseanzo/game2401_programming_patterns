using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    UnityEvent<GameObject> hitObject;
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

    public void OnCollisionEnter(Collision collision)
    {
        hitObject?.Invoke(collision.gameObject);
        //if (collision.gameObject.GetComponent<Animal>())
        //{
        //    ScoreManager.Instance.Score += 5;
        //    Destroy(collision.gameObject);
        //    Destroy(gameObject);
        //}
    }
}
