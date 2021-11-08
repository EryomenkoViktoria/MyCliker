using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    [SerializeField]
    private Button buttonLevel1, buttonLevel2, buttonLevel3, buttonLevel4, buttonLevel5, buttonLevel6, buttonLevel7, buttonMenu;

    private void Start()
    {
        buttonLevel1.onClick.AddListener(Level1);
        buttonLevel2.onClick.AddListener(Level2);
        buttonLevel3.onClick.AddListener(Level3);
        buttonLevel4.onClick.AddListener(Level4);
        buttonLevel5.onClick.AddListener(Level5);
        buttonLevel6.onClick.AddListener(Level6);
        buttonLevel7.onClick.AddListener(Level7);
        buttonMenu.onClick.AddListener(Menu);
    }

    private void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Level7()
    {
        SceneManager.LoadScene("Level7");
    }

    private void Level6()
    {
        SceneManager.LoadScene("Level6");
    }

    private void Level5()
    {
        SceneManager.LoadScene("Level5");
    }

    private void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

    private void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    private void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    private void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
}
