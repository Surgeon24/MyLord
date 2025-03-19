using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Метод для перехода к сцене с игрой
    public void StartNewGame()
    {
        SceneManager.LoadScene(1); // Загружаем сцену с индексом 1 (GameScene)
    }

    // Метод для выхода из игры
    public void ExitGame()
    {
        // В редакторе не работает, поэтому добавляем проверку
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
