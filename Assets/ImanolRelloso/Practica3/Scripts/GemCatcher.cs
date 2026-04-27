using UnityEngine;

public class GemCatcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gema"))
        {
            GameManager.instance.CatchGem(other.gameObject);
        }
    }
}
