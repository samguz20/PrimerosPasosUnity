
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
    {   Debug.Log("playerstats");
        if (_puntosVidaActuales >= 88)
        {  
            _uiManager.ColorBarra(Color.green);
            Debug.Log("verde");
        }

        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 88)
        {
            Debug.Log("amarillo");
            _uiManager.ColorBarra(new Color(245f, 73f, 39f, 255f));
        }  
        
        if (_puntosVidaActuales < 40)
        {
            Debug.Log("rojo");
            _uiManager.ColorBarra(new Color(189f, 15f, 15f, 255f));
        }
        
        if (_puntosVidaActuales > 100)
        {
            _puntosVidaActuales = 100;
        }
        if (_puntosVidaActuales < 0)
        {
            Destroy(this.gameObject);   
        }
    
    
   
    }




}
