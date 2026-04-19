using UnityEngine;

public class DeletePrefabs : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
            DeleteAll();
    }
    public void DeleteAll()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Placed");

        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
    }
}
