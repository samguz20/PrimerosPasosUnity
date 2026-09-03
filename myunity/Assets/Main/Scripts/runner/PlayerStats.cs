using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _puntosVida = 100f;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
        _puntosVida -= daño;
    }


    public void SumarVida(int Curacion)
    {
        _puntosVida = _puntosVida + Curacion;
      _puntosVida += Curacion;
     }

}