using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public TextMeshProUGUI valueText;

    private void Start()
    {
        valueText.text = PersistentManager.Instance.value.ToString();
    }

    public void GoToFirst()
    {
        SceneManager.LoadScene("first");
        PersistentManager.Instance.value++;
    }

    public void GoToSecond()
    {
        SceneManager.LoadScene("second");
        PersistentManager.Instance.value++;
    }
}
