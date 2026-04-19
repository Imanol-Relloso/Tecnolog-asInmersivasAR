using UnityEngine;
using UnityEngine.XR.ARFoundation.Samples;

public class ChangePrefab : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private GameObject prefab3;
    [SerializeField] private GameObject prefab4;

    [SerializeField] private PlaceOnPlane placeOnPlane;
    public void PrefabChange(int election)
    {
        switch (election)
        {
            case 0:
                placeOnPlane.m_PlacedPrefab = prefab1;
                break;
            case 1:
                placeOnPlane.m_PlacedPrefab = prefab2;
                break;
            case 2:
                placeOnPlane.m_PlacedPrefab = prefab3;
                break;
            case 3:
                placeOnPlane.m_PlacedPrefab = prefab4;
                break;
        }
    }
}
