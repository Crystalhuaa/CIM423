using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string changeScene)
    {
        SceneManager.LoadScene(changeScene);
    }
}
