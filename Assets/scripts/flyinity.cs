using UnityEngine;
using UnityEngine.Animations;

public class flyinity : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool BirdIsAlive = true;
    public AudioSource myAudioSource;
    public AudioClip[] MyAudioClips;
    public float spawnRate => 0.6f;
    private float timer = 0;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    { 
        timer = timer+Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive == true)
        {
            if (timer < spawnRate)
            {
                timer = timer;
                Debug.Log("timer is " + timer);
               
            }else
            {
                AudioClip randomClip = MyAudioClips[Random.Range(0, MyAudioClips.Length)];
                myAudioSource.PlayOneShot(randomClip);
                timer = 0;
                Debug.Log("timer is " + timer);
            }

            myRigidBody.linearVelocity = Vector2.up * flapStrength;
            GetComponent<Animator>().SetTrigger("trigger");




        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdIsAlive = false;
    }
}
