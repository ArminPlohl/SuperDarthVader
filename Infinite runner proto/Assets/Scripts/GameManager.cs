using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class GameManager : MonoBehaviour
{
    public GameObject Character;
    public float Score;
    public int Diffuculties = 0;

    private Platformer2DUserControl userControl;
    private bool isGamePaused;

    public HUDConroller hudScript;

    // Use this for initialization
    void Start()
    {
        userControl = Character.GetComponent<Platformer2DUserControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGamePaused)
        {
            Score += (Time.deltaTime * 100f);

            if (Score / 1000 > Diffuculties)
            {
                ++Diffuculties;
                userControl.CharacterSpeed *= 1.1f;

                Debug.Log("Character speed: " + userControl.CharacterSpeed);
            }

            hudScript.SetScore(Score);
        }
    }

    public void Retry()
    {
        Application.LoadLevel(0);
    }

    public void ChangeGamePause(bool isPaused)
    {
        isGamePaused = isPaused;

        if (isPaused)
        {
            userControl.CharacterSpeed = 0f;
        }
        else
        {
            userControl.CharacterSpeed = 1f;
        }
    }

    public void GameOver()
    {
        ChangeGamePause(true);

        // TODO: Menu popup
        Debug.Log("Died with score " + Score);

        hudScript.ShowMenu();

        //Retry();
    }

    public void Jump()
    {
        userControl.Jump();
    }

    public void SpeedUp()
    {
        userControl.CharacterSpeed = 1.2f;
    }

    public void NormalSpeed()
    {
        userControl.CharacterSpeed = 1f;
    }
}
