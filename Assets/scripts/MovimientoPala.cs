using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    public float velocidad;
    public bool jugadorb;

    // Update is called once per frame
    void Update()
    {
        float vertical = 0;
        float horizontal = 0;

        if (jugadorb)
        {
             vertical = Input.GetAxis("Vertical b");
            horizontal = Input.GetAxis("Horizontal b");
        }
        else
        {
             vertical = Input.GetAxis("Vertical a");
             horizontal = Input.GetAxis("Horizontal a");
        }
        transform.position = transform.position + new Vector3( horizontal, vertical, 0) * velocidad * Time.deltaTime;
    }
}
