using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject player;
    NavMeshAgent agent;
    public BarUI isCherryBool;
    public PlayerMovement Game;
    private float distance;
    public float enemyDistanceRun = 4.0f;
    public GameObject jail;
    private float xRange = 273;
    AudioSource audioSource;
    public AudioClip hitsound;
    // Start is called before the first frame update
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        audioSource = GetComponent<AudioSource>();

    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Game.isGame)
        {
            distance = Vector2.Distance(transform.position, player.transform.position);
            agent.SetDestination(player.transform.position);
        }

        if (isCherryBool.isCherry)
        {
            FleeEnemy();
        }
    }

    void FleeEnemy()
    {
        if (Game.isGame)
        {
            Vector2 newPos = (transform.position + 5 * (transform.position - player.transform.position));
            agent.speed = 120;
            agent.SetDestination(newPos);
        }
            
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PowerUp"))
        {
            audioSource.PlayOneShot(hitsound);
            gameObject.transform.position = jail.transform.position;//+ new Vector3();
            //isCherryBool.isCherry = false;
            
            //Destroy(gameObject);
        }
    }
}
