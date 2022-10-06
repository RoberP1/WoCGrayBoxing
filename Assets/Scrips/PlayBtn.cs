using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtn : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
