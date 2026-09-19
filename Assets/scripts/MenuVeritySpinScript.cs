using UnityEngine;

public class MenuVeritySpinScript : MonoBehaviour
{

    public float moveSpeed = 15;
    public float rotatespeed = 180;
    public float deadZone = -75;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.forward, rotatespeed * Time.deltaTime);

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
