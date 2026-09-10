using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    
    public void SumarFillAmount(float amount)   
    {
        _barra.fillAmount += amount;
        
    }

    
    public void RestarFillAmount(float amount) 
    {
        _barra.fillAmount = _barra.fillAmount - amount;
    }
}
