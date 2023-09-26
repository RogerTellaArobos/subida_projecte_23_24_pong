using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float velocidad;
    public GameObject pelota;


    // Update is called once per frame
    void Update()
    {

        float vertical = 0;
        float horizontal = 0;

        if(transform.position.y > pelota.transform.position.y)
        {
            vertical =-1;
        }

        if (transform.position.y < pelota.transform.position.y)
        {
            vertical =1;
        }
        transform.position = transform.position + new Vector3(horizontal, vertical, 0) * velocidad * Time.deltaTime;
    }

}
