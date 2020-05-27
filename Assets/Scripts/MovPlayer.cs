using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 300f;
    public float accspeed = 600f;

    float movement = 0f; //for Desktop
    float xpos = 0f;
    float ypos = 0f;
    

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            movement = Input.GetAxisRaw("Horizontal");
        }
          else
        {
             xpos = Input.acceleration.x;
             ypos = Input.acceleration.y;
        }
    }

    private void FixedUpdate()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -PlayerSpeed);

        }
      else
        {
            if(xpos > ypos)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, xpos * Time.fixedDeltaTime * -accspeed);
            }
            if (ypos > xpos)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, ypos * Time.fixedDeltaTime * -accspeed);
            }
                
        }
           
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {

        FindObjectOfType<GameManager>().GameOver();
    }
}
