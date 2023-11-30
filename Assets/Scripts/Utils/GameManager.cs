using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IGameObjectEventListener
{
    [SerializeField]
    float gameDuration = 20.0f;
    float currentTime = 0.0f;
    float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timeRemaining = gameDuration - currentTime;
        timeRemaining = timeRemaining >= 0.0f ? timeRemaining : 0.0f;
        Debug.LogFormat("Time remaining {0}. Score {1} ", timeRemaining, ScoreManager.Instance.Score);
    }
    public void OnEventRaised(GameObject gameObject)
    {

    }
}
