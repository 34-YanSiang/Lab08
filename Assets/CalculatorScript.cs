using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public GameObject USD;
    public GameObject JPY;
    public GameObject MYR;
    public GameObject Euro;
    public GameObject TWD;
    public GameObject Won;
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
            else if (MYR.GetComponent<Toggle>().isOn == true)
            {
                value = SGDAmount * 3.53f;
                if (value >= 10000000)
                {
                    value = value / 1000000;
                    Convertedvalue.text = value.ToString() + "mil MYR";
                }
                else
                    Convertedvalue.text = value.ToString() + " MYR";
            }

            else if (Euro.GetComponent<Toggle>().isOn == true)
            {
                value = SGDAmount * 0.68f;
                if (value >= 10000000)
                {
                    value = value / 1000000;
                    Convertedvalue.text = value.ToString() + "mil Euro";
                }
                else
                    Convertedvalue.text = value.ToString() + " Euro";
            }
            else if (Won.GetComponent<Toggle>().isOn == true)
            {
                value = SGDAmount * 995.36f;
                if (value >= 10000000)
                {
                    value = value / 1000000;
                    Convertedvalue.text = value.ToString() + "mil Won";
                }
                else
                    Convertedvalue.text = value.ToString() + " Won";
            }
            else if (TWD.GetComponent<Toggle>().isOn == true)
            {
                value = SGDAmount * 23.35f;
                if (value >= 10000000)
                {
                    value = value / 1000000;
                    Convertedvalue.text = value.ToString() + "mil TWD";
                }
                else
                    Convertedvalue.text = value.ToString() + " TWD";
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
