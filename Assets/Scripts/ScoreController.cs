using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreController : BaseController<ScoreController>
{
    public int score;
    public float combo;
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI comboText;

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

    public void Update()
    {
        scoreText.SetText(score.ToString("0"));
        comboText.SetText(combo.ToString("0.00"));
    }
}
