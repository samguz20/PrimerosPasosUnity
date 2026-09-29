using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    
            
   
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }


    public void PausarElJuego()
    {
        Time.timeScale = 0;
    }


    public void RenaudarElJuego()
    {
        Time.timeScale = 1;
    }





}
