
public class NuevaBase : Base
{
    public bool abrir = false;
    void Update()
    {
        if(abrir)
        {
            this.transform.Rotate(0f,0f,1f);
            if (gameObject.transform.rotation.eulerAngles.z > 270)    
            {
                abrir = false;
                Hijos[0].GetComponent<IATorre>().enabled = true;
            }
        }
    }
    public override void Crear()
    {
        if (Activo)
        {
            if (ManagerBanco.Puntuacion.Deposito(precio))
            {
                for (int i = 0; i < Hijos.Length; i++)
                {
                    if (i == Eleccion)
                    {
                        Hijos[i].SetActive(true);
                        abrir = true;
                        botonPadre.Prepararse();
                        //print($"Mostrate {Hijos[i].name}");
                    }
                    else
                    {
                        Hijos[i].SetActive(false);
                        //print($"Escondete {Hijos[i].name}");
                    }
                }
            }
        }
    }
    
    public override void activar(int v, BotonConstruir botonConstruir, int dinero)
    {
        if (!Hijos[v].activeSelf)
        {
            botonPadre = botonConstruir;
            Eleccion = v;
            Activo = true;
            precio = dinero;
        }
    }

    public override void activar()
    {
        Activo = false;
    }
}
