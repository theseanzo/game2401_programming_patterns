using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private int _score;
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            Debug.LogFormat("Score of {0}", _score);

        } //we will allow public setting and change of the score for now
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore(GameObject gameObject)
    {
        if (gameObject.GetComponent<Animal>())
        {
            _score += 5; //hard code 5 for now 
        }
    }
}
