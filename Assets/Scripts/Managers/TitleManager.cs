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
            Debug.LogError("StartButton�� �Ҵ���� ����");
        if (quitButton == null)
            Debug.LogError("QuitButton�� �Ҵ���� ����");
        if (settingsButton == null)
            Debug.LogError("SettingsButton�� �Ҵ���� ����");
    }

    private void Start()
    {
        startButton.GetComponent<Button>().onClick.AddListener(OnStartButtonClicked);
        quitButton.GetComponent<Button>().onClick.AddListener(OnQuitButtonClicked);
        settingsButton.GetComponent<Button>().onClick.AddListener(OnSettingsButtonClicked);
    }

    // ���� ��ư
    private void OnStartButtonClicked()
    {
        AudioManager.instance.PlayEffect("successButton");
        SceneManager.LoadScene("FactionSelectionScene");

    }

    // ���� ��ư
    private void OnQuitButtonClicked()
    {
        AudioManager.instance.PlayEffect("successButton");
        Debug.Log("���� ����");
    }

    // ���� ��ư
    private void OnSettingsButtonClicked()
    {
        
    }




}
