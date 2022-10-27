using UnityEngine;
using UnityEngine.SceneManagement;

public class changeAgain : MonoBehaviour
{
    public void StartSceneA()
    {
        SceneManager.LoadScene(sceneBuildIndex:3);
    }
}
