
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private int _puntosVidaMaximo = 100;
    [SerializeField] private UIManager _uiManager;
    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;
        
    }


    public void SumarVida(int vida)
    {
     _puntosVidaActuales += vida;
    }
    private void Update()
    {
        if (_puntosVidaActuales >= 80)
        {
            _uiManager.ColorBarra(new Color(68f, 189f, 68f, 255f));
        }

        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 80)
        {
            _uiManager.ColorBarra(new Color(245f, 73f, 39, 255));
        }

        if (_puntosVidaActuales < 40)
        {
            _uiManager.ColorBarra(new Color(189f, 15f, 255f));
        }


        if (_puntosVidaActuales >100)   
        {
            _puntosVidaActuales = 100;
        }
        if (_puntosVidaActuales <= 0)
        {
            Destroy(this.gameObject);
        }

        {
            Debug.Log("Game Over");
        }
    }
}
