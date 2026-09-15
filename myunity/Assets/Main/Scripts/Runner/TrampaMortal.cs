using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _manager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(10);
        }
    }
}