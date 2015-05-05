using UnityEngine;
using System.Collections;

public class MovingTemp : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * 2 * Time.deltaTime);
        //Debug.Log("Moving!");
    }
}
