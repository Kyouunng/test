using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{

    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
