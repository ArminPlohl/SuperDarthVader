using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] Objects;
    public float MinimumSpawnTime = 1f;
    public float MaxiumSpawnTime = 2f;

    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        GameObject obj = Instantiate<GameObject>(Objects[Random.Range(0, Objects.Length)]);

        Vector3 position = transform.position;

        position.y += Mathf.RoundToInt(Random.Range(0, 3)) * 3;

        obj.transform.position = position;
        
        Invoke("Spawn", Random.Range(MinimumSpawnTime, MaxiumSpawnTime));
    }
}