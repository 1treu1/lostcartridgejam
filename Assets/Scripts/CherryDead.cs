using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CherryDead : MonoBehaviour
{
    //public Image barPower;
    public bool isCherry;
    public delegate void OnCherryDead();
    public static event OnCherryDead onCherryDead;
    AudioSource audioSource;
    public AudioClip hitsound;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        isCherry = false;
    }
    


    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.CompareTag("Player"))
        {
            onCherryDead?.Invoke();

            audioSource.PlayOneShot(hitsound);
            Destroy(gameObject);
            //isCherry = true;

        }
    }
  
    
}
