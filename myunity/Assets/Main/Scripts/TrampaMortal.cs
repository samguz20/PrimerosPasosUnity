using System;
using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] public UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("El jugado ha recibido daño");
            _uiManager.RestarFillAmount(0.1f);
            _playerStats.RestarVida(10);
        }
    }
}