using br.com.Fonazo;
using UnityEngine;
using UnityEngine.SceneManagement;
using br.com.Fonazo.Game_Data;

namespace br.com.Fonazo
{
    namespace Managers
    {
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

        public interface IManager
        {
            void CheckInstance();
        }
    }
}