using System.Collections;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int horizontalGem = 2;
    public int verticalGem = 2;
    public float playTime = 30;
    public bool oclusion = false;

    private int catchedGems;
    private float timePassed;
    private bool lose;

    [SerializeField] private AudioSource tictac;
    [SerializeField] private AudioSource coin;

    private void Awake()
    {
        if(instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(tictac);
        DontDestroyOnLoad(coin);
    }

    public void StartGame()
    {
        if(oclusion)
            FindAnyObjectByType<XROrigin>().GetComponent<AROcclusionManager>().enabled = true;
        else
            FindAnyObjectByType<XROrigin>().GetComponent<AROcclusionManager>().enabled = false;


        StartCoroutine(Game());
        GameCanvas.instance.gameCanvas.SetActive(true);
    }

    public void CatchGem(GameObject gem)
    {
        if(lose) return;

        Destroy(gem);
        coin.Play();
        catchedGems++;

        if (catchedGems >= horizontalGem + verticalGem)
        {
            Win();
            return;
        }

        GameCanvas.instance.gemsText.text = "GEMAS ENCONTRADAS:" + catchedGems + "/" + (horizontalGem + verticalGem);
    }

    private void Win()
    {
        GameCanvas.instance.gemsText.text = "HAS GANADO";
    }
    private void Lose()
    {
        GameCanvas.instance.gemsText.text = "HAS PERDIDO";
        lose = true;
    }
    public void Empezar()
    {
        LoaderUtility.Deinitialize();
        LoaderUtility.Initialize();
        SceneManager.LoadScene("JuegoGemas");
    }
    public void Salir()
    {
        SceneManager.LoadScene("MenuGemas");
        Destroy(gameObject);
    }

    private IEnumerator Game()
    {
        timePassed = 0;
        tictac.Play();
        while (timePassed < playTime)
        {
            timePassed += Time.deltaTime;

            GameCanvas.instance.secondsText.text = "TIEMPO RESTANTE: " + ((int)(playTime - timePassed)).ToString();

            if (catchedGems >= horizontalGem + verticalGem)
                break;

            yield return null;
        }

        tictac.Stop();

        if (!(catchedGems >= horizontalGem + verticalGem))
            Lose();
    }
}
