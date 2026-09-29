using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
    
    public void PausarElJuego()
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
