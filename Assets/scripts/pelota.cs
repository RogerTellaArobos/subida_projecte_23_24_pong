using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3)direccion * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "vertical")
        {
         direccion = new Vector2(-direccion.x, direccion.y);
        }
        if (collision.gameObject.tag == "horizontal")
        {
         direccion = new Vector2(direccion.x, -direccion.y);
        }
    }
}
