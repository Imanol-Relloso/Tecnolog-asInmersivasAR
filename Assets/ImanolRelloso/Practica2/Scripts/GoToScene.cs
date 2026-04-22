using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public void goToScene(int scene)
    {
        if (scene == 0)
            SceneManager.LoadScene("dia2");
        else if (scene == 1)
            SceneManager.LoadScene("Escena1");
        else if (scene == 2)
            SceneManager.LoadScene("Practica2");
    }
}
