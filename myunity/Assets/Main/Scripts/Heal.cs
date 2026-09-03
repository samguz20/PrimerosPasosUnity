using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Player")
       {
        _playerStats.SumarVida(10);
        }
    }

}   
   
    

   