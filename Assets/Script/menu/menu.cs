using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
  public void jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Al presionar irá a la biblioteca
    }
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
