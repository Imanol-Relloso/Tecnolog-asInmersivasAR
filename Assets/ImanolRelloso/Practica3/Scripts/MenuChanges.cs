using TMPro;
using UnityEngine;

public class MenuChanges : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tiempoBusqueda;
    [SerializeField] private TextMeshProUGUI verGems;
    [SerializeField] private TextMeshProUGUI horGems;
    private void Update()
    {
        tiempoBusqueda.text = "TIEMPO DE BUSQUEDA: " + GameManager.instance.playTime.ToString();
        verGems.text = "GEMAS EN VERTICAL: " + GameManager.instance.verticalGem.ToString();
        horGems.text = "GEMAS EN HORIZONTAL: " + GameManager.instance.horizontalGem.ToString();
    }

    public void OnTimeChange(float time)
    {
        GameManager.instance.playTime = time;
    }
    public void OnHorGemsChange(float gems)
    {
        GameManager.instance.horizontalGem = (int)gems;
    }
    public void OnVerGemsChange(float gems)
    {
        GameManager.instance.verticalGem = (int)gems;
    }
    public void OnOclusionChange(bool oclusion)
    {
        GameManager.instance.oclusion = oclusion;
    }
}
