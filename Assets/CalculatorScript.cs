using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public GameObject USD;
    public GameObject JPY;
    public InputField txtAmount;
    public InputField Convertedvalue;
    private float SGDAmount;
    private float value;
    public void conversion()
    {
        try
        {
            SGDAmount = float.Parse(txtAmount.text);
            if (USD.GetComponent<Toggle>().isOn == true)
            {
                if (JPY.GetComponent<Toggle>().isOn == true)
                Convertedvalue.text = "Select Currency";
                else
                {
                    value = SGDAmount * 0.74f;
                    if (value >= 10000000)
                    {
                        value = value / 1000000;
                        Convertedvalue.text = value.ToString() + "mil USD";
                    }
                    else
                        Convertedvalue.text = value.ToString() + " USD";
                }
            }
            else if (JPY.GetComponent<Toggle>().isOn == true)
            {
                value = SGDAmount * 110.5f;
                if (value >= 10000000)
                {
                    value = value / 1000000;
                    Convertedvalue.text = value.ToString() + "mil JPY";
                }
                else
                    Convertedvalue.text = value.ToString() + " JPY";
            }
            else
                Convertedvalue.text = "Select Currency";
        }   
        catch(FormatException)
        {
            Convertedvalue.text = "Invalid amount";
        }
    }
    public void clear()
    {
        txtAmount.text = "";
        USD.GetComponent<Toggle>().isOn = false;
        JPY.GetComponent<Toggle>().isOn = false;
        Convertedvalue.text = "";
    }
}
