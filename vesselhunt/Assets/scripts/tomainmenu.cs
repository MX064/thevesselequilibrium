using UnityEngine;
using UnityEngine.SceneManagement;

public class controlstomenu : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadSceneAsync(0);
        SceneManager.LoadScene("lvl1-bar");
    }
}
