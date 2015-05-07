using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour
{
    public GameObject GameManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // TODO: Game over
            //Debug.Break();

            GameManager.SendMessage("GameOver");
            return;
        }

        if (collision.transform.parent != null)
        {
            Destroy(collision.transform.parent.gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
