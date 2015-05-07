using UnityEngine;
using System.Collections;

public class HUDConroller : MonoBehaviour
{
    public MenuScript script;
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
        script.HideMenu();
    }

    public void onJumpButtonClick()
    {
        Debug.Log("JUMP");
    }
}
