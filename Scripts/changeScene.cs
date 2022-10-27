using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void StartChange()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);
    }
}

