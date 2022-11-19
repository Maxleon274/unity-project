using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int xDir = 0;
    int yDir = 0;
    int x = 0;
    int y = 50;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (x == 450) { xDir = 1; }
        if (x == 0) { xDir = 0; }
        if (y == 450) { yDir = 1; }
        if (y == 0) { yDir = 0; }

        if (xDir == 0) { 
            transform.Translate(1 * Time.deltaTime ,0,0);
            x++;
        } 
        else { 
            transform.Translate(-1 * Time.deltaTime, 0, 0);
            x--;
        }

        if (yDir == 0) { 
            transform.Translate(0, 1 * Time.deltaTime , 0);
            y++;
        }
        else { 
            transform.Translate(0, -1 * Time.deltaTime , 0);
            y--;
        }
        transform.Rotate(0, 2, 0);

        Debug.Log("X: " + x + " Y: " + y + " xDir: " + xDir + " yDir: " + yDir);
    }
}
