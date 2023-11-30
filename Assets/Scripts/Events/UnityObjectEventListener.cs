using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityObjectEventListener : MonoBehaviour, IGameObjectEventListener
{
    [SerializeField]
    private ObjectEvent objectEvent;

    [SerializeField]
    private UnityEvent<GameObject> response;

    public void OnEnable()
    {
        objectEvent?.RegisterListener(this);
    }
    public void OnDisable()
    {
        objectEvent?.UnregisterListener(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEventRaised(GameObject gameObject)
    {
        response?.Invoke(gameObject);
    }
}
