using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class IntroManager : MonoBehaviour
{
    [SerializeField]
    private Button buttonMenu;

    SoundManager soundManager;

    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    private void Start()
    {
        buttonMenu.onClick.AddListener(MenuScenes);
    }

    private async void MenuScenes()
    {
        soundManager.ButtonClick();
        await Task.Delay(667);
        SceneManager.LoadScene(1);
    }
}
