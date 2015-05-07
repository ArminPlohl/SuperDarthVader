using UnityEngine;
using System.Collections;

public class PickupBonus : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.SendMessage("PickUpBonus");

            // Samouničenje
            Destroy(gameObject);

            return;
        }
    }
}
