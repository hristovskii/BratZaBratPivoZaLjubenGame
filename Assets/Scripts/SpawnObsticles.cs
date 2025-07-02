using UnityEngine;

public class SpawnObsticles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(x, y, 0), transform.rotation);
    }
}
