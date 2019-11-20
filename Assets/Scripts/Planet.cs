using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, Time.deltaTime * speed, 0);
            // = Quaternion.Euler(0, Time.deltaTime * speed, 0);
    }
}
