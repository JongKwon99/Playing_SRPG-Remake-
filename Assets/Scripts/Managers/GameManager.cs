using UnityEngine;
using UnityEngine.SceneManagement;

// 게임의 전반적인 흐름 및 전역 변수 관리
public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // 실행 중에 인스턴스가 없으면 새 GameObject를 생성
                var gameObject = new GameObject(nameof(GameManager));
                _instance = gameObject.AddComponent<GameManager>();
                DontDestroyOnLoad(gameObject);
            }
            return _instance;
        }
    }

    // 직접 접근할 수 있도록 Instance를 감추고 대신 정적 속성을 통해 접근
    public static GameState GameState => Instance.gameState;

    // 공개된 멤버 변수
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
            Destroy(gameObject); // 새로운 GameManager 생성 시도 시 기존 GameManager 파괴
        }
    }

    void Start()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // 디버깅용
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
