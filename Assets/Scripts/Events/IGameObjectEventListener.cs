using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameObjectEventListener 
{
    void OnEventRaised(GameObject gameObject);
}
