using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour

{
    [SerializeField] private Image _barra;
    [SerializeField] private UIManager _uiManager;

    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
        _barra.fillAmount= amount + _barra.fillAmount;
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount = _barra.fillAmount - amount;
    }