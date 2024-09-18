using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public int speed;
    private int s = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 50)
        {
            s = -1;
        }
        else if (transform.position.z <= -40)
        {
            s = 1;
        }

        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime * s);
    }
}
