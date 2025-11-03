using br.com.Fonazo;
using UnityEngine;
using UnityEngine.SceneManagement;
using br.com.Fonazo.Data.ScriptableObjects;
using br.com.Fonazo.Managers;

namespace br.com.Fonazo.Managers
{
    public interface IManager
    {
        void CheckInstance();
    }
}

public class GameManager : MonoBehaviour, IManager
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private GameData data;
            
    private void Start()
    {
        CheckInstance();
    }
            
    public void CheckInstance()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public float Convert(float value)
    {
        return data.ConvertMetric(value);
    }
}