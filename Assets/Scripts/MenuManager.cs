using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Button buttonLevels, buttonSettingsOn, buttonSettingsOff, buttonQuit;

    [SerializeField]
    private GameObject panelSettings;

    private void Start()
    {
        buttonLevels.onClick.AddListener(Levels);
        buttonSettingsOn.onClick.AddListener(SettingOn);
        buttonSettingsOff.onClick.AddListener(SettingOff);
        buttonQuit.onClick.AddListener(Quit);
    }

    private void Levels()
    {
        SceneManager.LoadScene(2);
    }

    private void SettingOn()
    {
        panelSettings.SetActive(true);
    }

    private void SettingOff()
    {
        panelSettings.SetActive(false);
    }

    private void Quit()
    {
        Application.Quit();
        Debug.Log("quit game");
    }
}
