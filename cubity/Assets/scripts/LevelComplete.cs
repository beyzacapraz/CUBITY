using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LoadNext(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+ 1);
    }
}
