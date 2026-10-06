
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private int _puntosVidaMaximo = 100;
    [SerializeField] private UIManager _uiManager;
    private int _recuperarvida = 10;
    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;
    }


    public void Restaurarvida(int heal)
    {
        _puntosVidaActuales = _puntosVidaActuales + _recuperarvida;
    }
    private void Update()
    {
        if (_puntosVidaActuales >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }

        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }

        if (_puntosVidaActuales < 40)
        {
            _uiManager.ColorBarra(Color.red);
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
