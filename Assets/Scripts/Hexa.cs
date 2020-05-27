using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hexa : MonoBehaviour
{
    public Rigidbody2D rb;
    float hexshrinkspeed = 1f ;

    public static bool GammePaused = false;
    
   // public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
        if (FindObjectOfType<spawner>().SpawnRate <= 2.5f)
        {
            hexshrinkspeed = hexshrinkspeed + 1f;

            if (FindObjectOfType<spawner>().SpawnRate <= 2f)
            {
                hexshrinkspeed = hexshrinkspeed + 1f;

            }else if (FindObjectOfType<spawner>().SpawnRate <= 1f)
            {
                hexshrinkspeed = 2f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!GammePaused)
        {
            if (FindObjectOfType<spawner>().SpawnRate <= 1)
            {
                hexshrinkspeed = hexshrinkspeed + 0.01f;
            }
            transform.localScale -= Vector3.one * hexshrinkspeed * Time.deltaTime;

            if (transform.localScale.x <= 0.5f)
            {
                Destroy(gameObject);
                FindObjectOfType<score>().Scoreupdate();

            }
        }
    }
}
