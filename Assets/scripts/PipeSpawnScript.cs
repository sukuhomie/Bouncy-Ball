using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipes;

    public float timer = 0;
    public float heightOffset = 15;

    public float BaseSpawnRate = 3;

    public int pipeCount = 0;

    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic")
            .GetComponent<LogicScript>();
    }

    void Update()
    {
        if (timer < BaseSpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();

            timer = 0;

            pipeCount++;

            // Every 5 pipes
            if (pipeCount >= 5)
            {
                pipeCount = 0;

                // Make pipes move faster
                logic.moveSpeed += 1;

                // Make pipes spawn more frequently
                BaseSpawnRate -= 0.15f;

                // Don't let spawn rate become 0 or negative
                if (BaseSpawnRate < 0.5f)
                {
                    BaseSpawnRate = 0.5f;
                }

                Debug.Log("Difficulty increased!");
                Debug.Log("Pipe Speed: " + logic.moveSpeed);
                Debug.Log("Spawn Rate: " + BaseSpawnRate);
            }
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(
            Pipes,
            new Vector3(
                transform.position.x,
                Random.Range(lowestPoint, highestPoint),
                transform.position.z
            ),
            transform.rotation
        );
    }
}