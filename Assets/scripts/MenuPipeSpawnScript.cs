using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawnScriptMenu : MonoBehaviour
{
    public GameObject Pipe;

    // float is for all numbers counting non rounds, decimals work when you put f after the decimal
    public float spawnRate = 0.5f;
    private float timer = 0;
    public float heightOffset = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, transform.position.y), transform.rotation);
    }
}
