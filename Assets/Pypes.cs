using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pypes : MonoBehaviour
{

public float tate = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(-0.01f, tate, 0f);

        if (transform.position.y == -2.24)
        {
            tate = 0.01f;
        }
        else if (transform.position.y >= -2.18)
        {
            tate = -0.01f;
        }
        else if (transform.position.y <= -2.30)
        {
            tate = 0.01f;
        }

    }

}

