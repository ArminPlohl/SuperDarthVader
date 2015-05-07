using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    Animator animator;

    int showHash, hideHash;

    public GameObject jumpArea;
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
            jumpArea.SetActive(false);

        }
    }

    public void HideMenu()
    {
        animator.SetTrigger(hideHash);
        jumpArea.SetActive(true);
    }
}
