using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl1tolvl2 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
