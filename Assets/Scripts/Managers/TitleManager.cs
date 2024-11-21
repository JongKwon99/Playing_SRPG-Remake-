using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;
    public GameObject settingsButton;

    private void Awake()
    {
        if (startButton == null)
            Debug.LogError("StartButton이 할당되지 않음");
        if (quitButton == null)
            Debug.LogError("QuitButton이 할당되지 않음");
        if (settingsButton == null)
            Debug.LogError("SettingsButton이 할당되지 않음");
    }

    private void Start()
    {
        startButton.GetComponent<Button>().onClick.AddListener(OnStartButtonClicked);
        quitButton.GetComponent<Button>().onClick.AddListener(OnQuitButtonClicked);
        settingsButton.GetComponent<Button>().onClick.AddListener(OnSettingsButtonClicked);
    }

    // 시작 버튼
    private void OnStartButtonClicked()
    {
        AudioManager.instance.PlayEffect("successButton");
        SceneManager.LoadScene("FactionSelectionScene");

    }

    // 종료 버튼
    private void OnQuitButtonClicked()
    {
        AudioManager.instance.PlayEffect("successButton");
        Debug.Log("게임 종료");
    }

    // 설정 버튼
    private void OnSettingsButtonClicked()
    {
        
    }




}
