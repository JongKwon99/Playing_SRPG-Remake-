using UnityEngine;
using UnityEngine.SceneManagement;

// ������ �������� �帧 �� ���� ���� ����
public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // ���� �߿� �ν��Ͻ��� ������ �� GameObject�� ����
                var gameObject = new GameObject(nameof(GameManager));
                _instance = gameObject.AddComponent<GameManager>();
                DontDestroyOnLoad(gameObject);
            }
            return _instance;
        }
    }

    // ���� ������ �� �ֵ��� Instance�� ���߰� ��� ���� �Ӽ��� ���� ����
    public static GameState GameState => Instance.gameState;

    // ������ ��� ����
    public GameState gameState;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject); // ���ο� GameManager ���� �õ� �� ���� GameManager �ı�
        }
    }

    void Start()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // ������
    private void Update()
    {
        
    }
}

public enum GameState
{
    TitleScreen,
    FactionSelection,
    UnitSelection,
    InitialDeployment,
    InGame
}
