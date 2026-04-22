using Unity.XR.CoreUtils;
using UnityEngine;

public class InContact : MonoBehaviour
{
    [SerializeField]
    private GameObject canvasAzul;
    [SerializeField]
    private GameObject canvasRojo;

    private void Start()
    {
        canvasAzul.SetActive(false);
        canvasRojo.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Azul"))
        {
            canvasAzul.SetActive(true);
        }
        else if (other.CompareTag("Rojo"))
        {
            canvasRojo.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Azul"))
        {
            canvasAzul.SetActive(false);
        }
        else if (other.CompareTag("Rojo"))
        {
            canvasRojo.SetActive(false);
        }
    }
}
