using System.Runtime.CompilerServices;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _puntosVida = 100f;
    [SerializeField] private UIManager _uiManager;
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
  private void Update()
{
    if (/*vida del jugador*/ >= 80)
    {
        _uiManager.color = (Color.white);
    }

    if (40 <= /*vida del jugador*/ < 80)
    {
        _uiManager.ColorBarra = (new Color(1f, 1f, 1f, 1f));
    }

    if (/*vida del jugador*/ < 40)
    {
        _uiManager.ColorBarra = (new Color(1f, 0f, 0f, 1f));
    } 

}