using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDConroller : MonoBehaviour
{
    public MenuScript script;

    public Text gameOverScore;
    public Text score;

    public GameManager gmScript;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onButtonClick()
    {
        Application.LoadLevel(0);
    }

    public void ShowMenu()
    {
        gameOverScore.text = score.text;
        script.ShowMenu();
    }

    public void SetScore(float currentScore)
    {
        this.score.text = currentScore.ToString();
    }
}
