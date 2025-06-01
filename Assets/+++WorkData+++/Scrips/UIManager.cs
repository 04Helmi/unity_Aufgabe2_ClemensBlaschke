using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour

{

    [SerializeField] GameObject MainMenuPanel;
    [SerializeField] GameObject LosePanel;
    [SerializeField] GameObject WinPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainMenuPanel.SetActive(true);
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenLosePanel()
    {
        LosePanel.SetActive(true);
    }

    public void openMainMenuPanel()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void closeMainMenuPanel() 
    {
        MainMenuPanel.SetActive(false);
    }

    public void OpenWinPanel()
    {
        WinPanel.SetActive(true);
    }
}
