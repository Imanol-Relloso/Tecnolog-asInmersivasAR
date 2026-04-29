using UnityEngine;

public class TocarFlecha : MonoBehaviour
{
    [SerializeField] private AudioSource sonido;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Camino>())
        {
            other.GetComponentInParent<Camino>().nextFlecha();
            sonido.Play();
        }
    }
}
