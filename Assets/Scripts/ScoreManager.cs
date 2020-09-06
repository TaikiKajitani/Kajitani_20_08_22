using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    int score = 0;
    public Text text;
    public string exsText = "枚";
    //スコアを増やす
    public void AddScore()
    {
        score++;
        text.text = score.ToString() + exsText;
    }
    private void Start()
    {
        text.text = score.ToString() + exsText;
    }
}
