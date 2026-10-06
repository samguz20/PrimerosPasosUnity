using TMPro.EditorUtilities;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    public int _puntosVidaActuales;
    [SerializeField] private UIManager _uiManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("Player"))
        {
            if(_puntosVidaActuales <100)
            {
                _playerStats.Restaurarvida(5);
                _uiManager.SumarFillAmount(0.5f);
                Destroy(this.gameObject);
            }
            
           
            Destroy(this.gameObject);
        }
    }

}   
   
    

   