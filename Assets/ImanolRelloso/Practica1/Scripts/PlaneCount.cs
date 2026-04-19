using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlaneCount : MonoBehaviour
{
    private TextMeshProUGUI tmp;

    [SerializeField] private ARPlaneManager planeManager;
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        tmp.text = "Planos: " + planeManager.trackables.count;
    }
}
