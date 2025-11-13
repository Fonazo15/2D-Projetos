using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.AI
{
    [CreateAssetMenu(fileName = "NewEntityData", menuName = "Game Data/Entity")]
    public class EntityData : ScriptableObject
    {
        public PlayerRelationship Relationship { get { return _relationToPlayer; } }
        [SerializeField] private PlayerRelationship _relationToPlayer;

        public string entityUUID;
        public float speed;
        public float jumpForce;
        public float attackCooldown;
        public float detectionRange;
    }
    public enum PlayerRelationship
    {
        Passive,
        Aggressive,
        Neutral
    }
}
