using br.com.Fonazo;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace br.com.Fonazo.Managers
{
    public interface IManager
    {
        void CheckInstance();
    }

    public class GameManager : MonoBehaviour, IManager
    {
        public static GameManager Instance { get; private set; }
            
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
    }
}