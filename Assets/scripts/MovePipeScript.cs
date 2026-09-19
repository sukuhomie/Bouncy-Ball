using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic")
            .GetComponent<LogicScript>();
    }

    void Update()
    {
        transform.position += Vector3.left * logic.moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}