using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image healthGlobe, manaGlove;
    [SerializeField] private Slider xpSlider;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private TMP_Text levelText;

    public void UpdateLevelText(int level)
    {
        levelText.text = level.ToString();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // healthGlobe.fillAmount = health.GetHealthRatio();
       healthGlobe.fillAmount = Mathf.Lerp(healthGlobe.fillAmount, health.GetHealthRatio(), 2 * Time.deltaTime);

    }

    public void UpdateXpSlider(float xpRatio)
    {
        xpSlider.value = xpRatio;
    }
}
