using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class Animal : MonoBehaviour
{
    [SerializeField]
    Vector3 movementDirection;

    [SerializeField]
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
