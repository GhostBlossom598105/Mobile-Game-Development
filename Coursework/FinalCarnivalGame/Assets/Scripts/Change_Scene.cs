using UnityEngine.SceneManagement;
using UnityEngine;

public class Change_Scene : MonoBehaviour
{

    public void MenuChangeScene()
    {
        SceneManager.LoadScene("SampleLevel");
    }

    public void GameChangeScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}
