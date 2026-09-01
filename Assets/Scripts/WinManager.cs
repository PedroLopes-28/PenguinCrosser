using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour {
    public GameObject winPanel;

    public void Win(){
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
