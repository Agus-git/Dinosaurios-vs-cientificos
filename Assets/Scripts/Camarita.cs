using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarita : MonoBehaviour
{
    public LayerMask layer;
    Base Base;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit InformacionDelRayo;
            if (Physics.Raycast(rayo, out InformacionDelRayo, 10000f, layer))
            {
                Base = InformacionDelRayo.collider.GetComponent<Base>();
                print(Base.gameObject.name);
                Base.Crear();
            }
        }
    }
}
