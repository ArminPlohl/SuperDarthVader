using UnityEngine;
using System.Collections;

public class RunnerCamera : MonoBehaviour
{
    public GameObject CharacterObject;
    public float DistanceFromCharacter = 2f;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        // Spremenimo le X os kamere
        position.x = CharacterObject.transform.position.x + DistanceFromCharacter;

        transform.position = position;

        // Ker vemo y in z kamere, lahko tudi tako napišemo:
        //transform.position = new Vector3(transform.position.x + DistanceFromCharacter, 0, -10);
    }
}
