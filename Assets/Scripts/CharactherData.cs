using UnityEngine;

[CreateAssetMenu(fileName = "Default Characther Data", menuName = "Game/Data/Charathers Data")]
public class CharactherData : ScriptableObject
{
    public float attackCooldown;
    public float damage;
    [SerializeField]    private float _maxHealth;
    public float currentHealth;

    public enum AttackType
    {
        Energy,
        Sharp,
        Explosive,
        Weak,
        Strong
    }
    public AttackType attackType;
    public void TakeDamage(float damageTaken)
    {
        currentHealth -= damageTaken;
    }

    public void RegenerateHealth(float regenValue)
    {
        if (!(currentHealth <= 0))
        {
            if (regenValue > _maxHealth)     regenValue = _maxHealth;

            else    currentHealth += regenValue;
        }
    }
}