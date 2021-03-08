using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float highscore;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("highscore") != null)
        {
            highscore = PlayerPrefs.GetFloat("highscore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(float amount)
    {
        score += amount;
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("highscore", score);
        }
    }
}
