using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaneCounter : MonoBehaviour
{
    public static PlaneCounter Instance;

    public ARPlaneManager planeManager;

    public int horizontal;
    public int vertical;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }
    /*
    void OnEnable()
    {
        planeManager.trackablesChanged += OnPlanesChanged;
    }

    void OnDisable()
    {
        planeManager.trackablesChanged -= OnPlanesChanged;
    }
    */
    private void Update()
    {
        OnPlanesChanged();
    }

    void OnPlanesChanged()
    {
        vertical = 0;
        horizontal = 0;

        foreach (var plane in planeManager.trackables)
        {
            if (plane.alignment == PlaneAlignment.Vertical)
            {
                vertical++;
            }
            else if (plane.alignment == PlaneAlignment.HorizontalUp)
            {
                horizontal++;
            }
        }

    }
}
