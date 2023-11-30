using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    Projectile projectile;
    [SerializeField]
    GameObject launchOrigin;
    [SerializeField]
    float projectileSpeed = 700.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Projectile bullet = Instantiate(projectile.gameObject, launchOrigin.transform.position,
                                                    launchOrigin.transform.rotation).GetComponent<Projectile>();
            bullet.Shoot(-Vector3.right, projectileSpeed);
        }
    }
}
