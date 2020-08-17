using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;

    public int moveVel = 5;

    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.x > endPos.position.x)
        {    
            Vector3 pos = transform.position;
            pos.x -=  Time.deltaTime * moveVel;
            pos.y = (player.transform.position.y + 8.14f) / 3;
            transform.position = pos;
        }
        else
        {
            transform.position = startPos.position;
        }

    }
}
