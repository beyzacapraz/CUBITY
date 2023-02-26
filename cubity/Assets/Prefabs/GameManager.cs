using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = true;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public TextMeshProUGUI level;
    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }
    
    public void GameOver(){
        if(gameHasEnded){
            gameHasEnded = false;
            Debug.Log("Game Over!!");
            Invoke("Restart",1f);
        }
    }
    void Restart(){
        if(gameHasEnded == false){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
