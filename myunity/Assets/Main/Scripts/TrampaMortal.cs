using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            //Destroy(collision.gameObject);
            _playerStats.RestarVida(10);
        }
    }
}