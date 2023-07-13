using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int priceHealth = 50;
    public int priceSpeed = 50;
    public int priceGun = 50;
    public Text Displaytext;
    public UI ui;
    public GameControll gameController;
    public HealthPlayer playerHealth;
    public TankMover playermove;
    public TankFirer tankFirer;
    // Start is called before the first frame update

    public void Buyhealth()
    {
        if (0 < playerHealth.currentHealth && playerHealth.currentHealth < playerHealth.maxHealth && gameController.m_score >= priceHealth)
        {
            playerHealth.Heal(20);

            gameController.m_score -= priceHealth;
            ui.m_Score.text = "" + gameController.m_score;
            Displaytext.text = "Successfully bought blood!";
            StartCoroutine(DisplayTextForTime());
        }
        else if (gameController.m_score < priceHealth)
        {
            Displaytext.text = "Not enough money buy health!!!";
            StartCoroutine(DisplayTextForTime());

        }
        if (playerHealth.currentHealth == playerHealth.maxHealth)
        {
            playerHealth.currentHealth += 0;
            ui.textScore("" + gameController.m_score);
            Displaytext.text = "Full of bool!";
            StartCoroutine(DisplayTextForTime());
        }
    }
    public void BuySeep()
    {
        if (gameController.m_score > priceSpeed)
        {
            playermove.speed += 0.3f;
            gameController.m_score -= priceSpeed;
            ui.m_Score.text = "" + gameController.m_score;
            Displaytext.text = "Successfully bought speed!";
            StartCoroutine(DisplayTextForTime());
        }
        else
        {
            Displaytext.text = "Not enough money buy speed!!!";
            StartCoroutine(DisplayTextForTime());
        }

    }
    public void BuyGun()
    {
        if (gameController.m_score > priceGun)
        {
            
            if (tankFirer.delay > 0.3f)
            {
                tankFirer.delay -= 0.01f;
            }
            if (tankFirer.delay <= 0.3f)
            {
                tankFirer.delay -= 0f;
            }
            gameController.m_score -= priceGun;
            ui.m_Score.text = "Coin:" + gameController.m_score;
            Displaytext.text = "Successfully bought damage bullet!";
            StartCoroutine(DisplayTextForTime());
        }
        else
        {
            Displaytext.text = "Not enough money buy damage bullet!!!";
            StartCoroutine(DisplayTextForTime());
        }

    }
    IEnumerator DisplayTextForTime()
    {
        Displaytext.enabled = true;
        yield return new WaitForSeconds(1);
        Displaytext.enabled = false;
    }

    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameControll>();
    }
}
