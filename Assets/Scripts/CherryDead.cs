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


            Destroy(gameObject);
            //isCherry = true;

        }
    }
  
    
}
