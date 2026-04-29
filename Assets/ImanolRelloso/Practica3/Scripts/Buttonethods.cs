using UnityEngine;

public class Buttonethods : MonoBehaviour
{
    public void Salir()
    {
        GameManager.instance.Salir();
    }
    public void Empezar()
    {
        GameManager.instance.Empezar();
    }
}
