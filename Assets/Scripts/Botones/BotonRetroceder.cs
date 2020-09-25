using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonRetroceder : MonoBehaviour
{
    public List<GameObject> Apagar;
    public List<GameObject> Prender;

    public void Activar()
    {
        foreach (var item in Apagar)
        {
            item.SetActive(false);
        }
        foreach (var item in Prender)
        {
            item.SetActive(true);
        }
        this.gameObject.SetActive(false);
    }
}
