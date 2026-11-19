using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //load the main game scene when the start button is clicked
    public void StartGame()
    {
        
        SceneManager.LoadScene("GameScene");
    }

    // return the player to the main menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    // close the game application
    public void QuitGame()
    {
        // logs a message in the console to make sure the button work in the unity editor
        Debug.Log("Exiting game");
        #if UNITY_EDITOR
        // make the button exist work in the editor
            UnityEditor.EditorApplication.isPlaying = false;
        #else
        //quit the application (only work in built game)
            Application.Quit();
        #endif

    }
}
