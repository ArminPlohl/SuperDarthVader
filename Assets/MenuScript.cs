using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{

    Animator animator;

    int showHash, hideHash;
    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        showHash = Animator.StringToHash("Show");
        hideHash = Animator.StringToHash("Hide");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger(showHash);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger(hideHash);
        }
    }

    public void HideMenu()
    {
        animator.SetTrigger(hideHash);
    }
}
