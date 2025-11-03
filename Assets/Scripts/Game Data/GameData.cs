using UnityEngine;

namespace br.com.Fonazo.Data.ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewGameData", menuName = "Game Data/General Data", order = -100)]
    public class GameData : ScriptableObject
    {
        [SerializeField]
        [Range(0f, 5f)]
        private float conversionRate;

        public float ConvertMetric(float toConvert)
        {
            return toConvert * conversionRate;
        }
    }
}