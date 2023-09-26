using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuprincipal : MonoBehaviour
{
    // Start is called before the first frame update
   public void cargarjugador1()
    {
        Debug.Log("load player 1");
        SceneManager.LoadScene("1jugador");
    }

    // Update is called once per frame
    public void cargarjugador2()
    {
        Debug.Log("load player 2");
        SceneManager.LoadScene("2jugadores");
    }
}
