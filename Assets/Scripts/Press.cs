using UnityEngine;
using TMPro;
public class Press : MonoBehaviour
{
    private TextMeshProUGUI numberLabel;
    
    // just some text
    int number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberLabel= GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreseNumber()
    {
        numberLabel.text = (number += 1).ToString();
        
    }


    public void DecreaseNumber()
    {
        numberLabel.text = (number -= 1).ToString();
        
    }


    
    public void ResetNumber()
    {
        numberLabel.text = (number = 0).ToString();
        
    }
}
