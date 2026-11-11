using UnityEngine.SceneManagement;
using UnityEngine;

public class Change_Scene : MonoBehaviour
{

    public void MenuChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameChangeScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}
