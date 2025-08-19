using UnityEngine;
using Game;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]    private CharactherData enemyData;
    [SerializeField]    private float _speed = 3f;
    private Board boardReference = new Board();
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, -boardReference.BoardSize, _speed * Time.deltaTime);
    }
}
