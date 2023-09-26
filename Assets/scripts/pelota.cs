using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    public puntuación punt;
    // Update is called once per frame
    private void Start()
    {
        spawn();
    }
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
        if (collision.gameObject.tag == "porteria a")
        {
            Debug.Log("entrando porteria a");
            punt.puntuacionA = punt.puntuacionA + 1;
            spawn();
        }
        if (collision.gameObject.tag == "porteria b")
        {
            Debug.Log("entrando porteria b");
            punt.puntuacionB = punt.puntuacionB + 1;
            spawn();
        }
    }

    void spawn()
    {
        transform.position = new Vector3(0, 0);
        float x = Random.Range(-1f,1f);
        if(x >0)
        {
            x = 1;

        }
        else
        {
            x = -1;
        }
        float y = Random.Range(-1, 1);
        direccion = new Vector2(x, y);
    }
}

