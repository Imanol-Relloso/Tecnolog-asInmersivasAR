using TMPro;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    public static GameCanvas instance;

    [SerializeField] public GameObject gameCanvas;
    [SerializeField] public TextMeshProUGUI gemsText;
    [SerializeField] public TextMeshProUGUI secondsText;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    private void Start()
    {
        gameCanvas.SetActive(false);
    }
}
