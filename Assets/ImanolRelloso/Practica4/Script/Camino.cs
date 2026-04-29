using UnityEngine;

public class Camino : MonoBehaviour
{
    public GameObject[] flechas;
    private int ultimaFlecha;

    void Start()
    {
        flechas = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            flechas[i] = transform.GetChild(i).gameObject;
            flechas[i].SetActive(false);
        }

        flechas[0].SetActive(true);
    }

    public void nextFlecha()
    {
        flechas[ultimaFlecha]?.SetActive(false);

        ultimaFlecha++;

        flechas[ultimaFlecha]?.SetActive(true);
    }
}
