using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
    }

    public void IncrementBy(int number)
    {
        this.score += number;
    }
}
