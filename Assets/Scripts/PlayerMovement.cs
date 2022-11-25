using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 10;
    float horizontalInput;
    float verticalInput;

    public delegate void PointDelegate();
    public event PointDelegate Point;
    public delegate void GrapeDelegate();
    //public event GrapeDelegate Grape;
    public float time = 0;
    public bool isGame = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontalInput,verticalInput) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point" && Point != null)
        {
            Point();
            //Grape();
        }
    }

    /*
     GameObject children = Instantiate(childrenPrefab, new Vector3(-189, -148, 0), Quaternion.identity) as GameObject;
     children.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
     */

}
