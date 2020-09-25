using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDeJuego : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            SceneManager.LoadScene(2);
            Scene actual = SceneManager.GetActiveScene();
            SceneManager.UnloadSceneAsync(actual);
        }
    }
}
