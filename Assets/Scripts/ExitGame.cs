using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void GameExit()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
        Debug.Log("fffffff");

    }
}