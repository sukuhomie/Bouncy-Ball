using Unity.VisualScripting;
using UnityEngine;

public class MenuVeritySpawnScript : MonoBehaviour
{
    public GameObject Verity;

    // float is for all numbers counting non rounds, decimals work when you put f after the decimal
    public float spawnRate = 0.8f;
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

        Instantiate(Verity, new Vector3(transform.position.x, transform.position.y), transform.rotation);
    }
}
