using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helo : MonoBehaviour
{
   public float speed;
    public Transform[] moveSpots;
    private int current;
    // Start is called before the first frame update
    void Start()
    {
        current=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position!=moveSpots[current].position){
            transform.position = Vector2.MoveTowards(transform.position,moveSpots[current].position,speed*Time.deltaTime);

        }
        else{
            current=(current+1)%moveSpots.Length;
        }
    
    }
}
