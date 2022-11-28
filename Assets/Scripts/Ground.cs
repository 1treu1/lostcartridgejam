using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] public SpriteRenderer ground;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        ColorSet();
    }

    void ColorSet()
    {
        ground.color = new Color(Random.value, Random.value, Random.value, 10.0f);

    }
}
