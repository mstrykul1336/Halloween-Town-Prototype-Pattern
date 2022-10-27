using UnityEngine;
using UnityEngine.SceneManagement;

public class changeMenu : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}


