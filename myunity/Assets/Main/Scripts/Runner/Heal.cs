using UnityEngine;

public class Heal : MonoBehaviour
{
    
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerStats.SumarVida(5);
            _uiManager.SumarFillAmount(0.5f);
            Destroy(this.gameObject);
        }
    }


}
