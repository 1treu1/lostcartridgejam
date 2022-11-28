using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 10;
    float horizontalInput;
    float verticalInput;

    public delegate void PointDelegate();
    public event PointDelegate Point;
    //public delegate void PowerDelegate();
    //public event PowerDelegate Power;
    public float time = 0;
    public bool isGame = true;
    public bool isCherry;
    public GameObject colliderPlayer;
    private float xRange = 273;
    AudioSource audioSource;
    public AudioClip hitsound;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        CherryDead.onCherryDead += IsCherry;
    }
    void Start()
    {
        bool isGame = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        
        if (transform.position.x < 168.2)
        {
            transform.position = new Vector2(174, transform.position.y);
        }
        if (transform.position.x > 174.5f)
        {
            transform.position = new Vector2(168.4f, transform.position.y);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontalInput,verticalInput) * moveSpeed * Time.deltaTime);
        if (isCherry)
        {
            time += Time.deltaTime;
            //Debug.Log("Timer " + time);
            if (time >= 4)
            {
                //Debug.Log("Timer Off "+ time);
                gameObject.tag = "Player";
                colliderPlayer.tag = "Player";
                isCherry = false;
                time = 0;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.gameObject.tag == "Point" && Point != null)
        {
            audioSource.PlayOneShot(hitsound);
            Point();
            //Grape();
        }

        if (collision.CompareTag("Enemy") && gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            Destroy(gameObject);
            isGame = false;
        }


    }
    void IsCherry()
    {
        isCherry = true;
        gameObject.tag = "PowerUp";
        colliderPlayer.tag = "PowerUp";
    }
    private void OnDisable()
    {
        CherryDead.onCherryDead -= IsCherry;
    }

    /*
     GameObject children = Instantiate(childrenPrefab, new Vector3(-189, -148, 0), Quaternion.identity) as GameObject;
     children.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
     */

}
