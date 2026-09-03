using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    private int _sumarVida = 10;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
        

    }
    public void SumarVida(int heal)
    {
        _puntosVida = _puntosVida + heal;


    }
}
