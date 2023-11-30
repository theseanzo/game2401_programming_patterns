using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    // Start is called before the first frame update
    [SerializeField]
    AudioSource animalSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectHitSound(GameObject gameObject)
    {
        if (gameObject.GetComponent<Animal>())
        {
            animalSound?.Play();
        }
    }
}
