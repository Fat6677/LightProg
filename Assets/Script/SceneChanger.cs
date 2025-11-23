using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene("Level");
    }
}
