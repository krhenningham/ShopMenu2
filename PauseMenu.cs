using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject shopMenu;
    int damage;
    int fireRate;
    int health;

    void Update()
    {


    }

    public void Shop()
    {
        shopMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Exit()
    {
        shopMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void updgradeDamage()
    {
        damage += 5;
    }

    public void upgradeFireRate()
    {
        fireRate += 1;
    }

    public void healHearts()
    {
        health += 5;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
