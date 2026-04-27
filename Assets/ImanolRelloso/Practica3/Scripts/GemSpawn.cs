using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class GemSpawn : MonoBehaviour
{
    private int horPlaneGems;
    private int verPlaneGems;

    [SerializeField] private GameObject gem;

    [SerializeField] private GameObject button;
    [SerializeField] private GameObject canvas;
    [SerializeField] private TextMeshProUGUI horText;
    [SerializeField] private TextMeshProUGUI verText;

    private void Start()
    {
        horPlaneGems = GameManager.instance.horizontalGem;
        verPlaneGems = GameManager.instance.verticalGem;
    }

    private void Update()
    {
        horText.text = "HORIZONTALES: " + PlaneCounter.Instance.horizontal + "/" + horPlaneGems;
        verText.text = "VERTICALES: " + PlaneCounter.Instance.vertical + "/" + verPlaneGems;

        if (horPlaneGems <= PlaneCounter.Instance.horizontal && verPlaneGems <= PlaneCounter.Instance.vertical)
            button .SetActive(true);
        else
            button .SetActive(false);
    }

    public void OnStart()
    {
        foreach (var plane in PlaneCounter.Instance.planeManager.trackables)
        {
            if (plane.alignment == PlaneAlignment.Vertical)
            {
                if (verPlaneGems > 0)
                {
                    Instantiate(gem, plane.transform.position, Quaternion.identity);
                    verPlaneGems--;
                }
            }
            if (plane.alignment == PlaneAlignment.HorizontalUp)
            {
                if (horPlaneGems > 0)
                {
                    Instantiate(gem, plane.transform.position, Quaternion.identity);
                    horPlaneGems--;
                }
            }

            if(horPlaneGems <= 0 && verPlaneGems <= 0)
                break;
        }

        canvas.SetActive(false);

        GameManager.instance.StartGame();
    }
}
