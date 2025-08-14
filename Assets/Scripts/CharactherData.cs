using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "CharactherData", menuName = "Scriptable Objects/CharactherData")]
public class CharactherData : ScriptableObject
{
    public enum CharaterType
    {
        Tower,
        Enemy
    }
    public CharaterType type;

    public string characterName;
    public float _attackCooldown;
    public float AttackSpeed
    {
        get
        {
            return _attackCooldown / 100;
        }
        set
        {
            _attackCooldown = value * 100;
        }
    }
    public void ModifyAttackSpeed(float modifier)
    {
        AttackSpeed *= modifier;
    }
    public IEnumerator AttackCourotine()
    {
        yield return new WaitForSeconds(_attackCooldown);
        Attack();
        yield break;
    }
    public void Attack()
    {

    }
}
