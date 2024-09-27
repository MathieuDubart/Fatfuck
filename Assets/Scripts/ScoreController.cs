using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : BaseController<ScoreController>
{
    public int score;
    public float combo;

    // Start is called before the first frame update
    void Start()
    {
        ResetScoreAndCombo();
    }

    //increment score with type casting
    public void IncrementScoreBy(int number) { this.score += (int)Mathf.Ceil((float)number* this.combo); }

    public void IncrementComboWith(float number) { this.combo = (this.combo + number) < 5 ? this.combo += number : 5; }

    public void ResetCombo() { this.combo = 1; }

    public void ResetScoreAndCombo() { this.score = 0; this.combo = 1; }

}
