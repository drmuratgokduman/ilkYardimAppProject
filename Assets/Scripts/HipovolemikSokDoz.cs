using TMPro;
using UnityEngine;

public class HipovolemikSokDoz : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TMP_InputField kgInput;
    [SerializeField] private TMP_Text dozText;
    void Start()
    {
        dozText.text = "";
    }

    public void SFHesapla()
    {
        if (kgInput.text == "")
        {
            dozText.text = "Lütfen geçerli bir kilo giriniz.";
            return;
        }
        float kg = float.Parse(kgInput.text);
        if (kg <= 0)
        {
            dozText.text = "Lütfen geçerli bir kilo giriniz.";
            return;
        }
        float doz = kg * 10; // 10 mg/kg
        dozText.text = doz.ToString("F0") + "ml (10-20dk) 3 kez tekrarlanabilir.";
    }

    public void DopaminHesapla()
    {
        if (kgInput.text == "")
        {
            dozText.text = "Lütfen geçerli bir kilo giriniz.";
            return;
        }
        float kg = float.Parse(kgInput.text);
        if (kg <= 0)
        {
            dozText.text = "Lütfen geçerli bir kilo giriniz.";
            return;
        }
        float doz = kg * 5;
        dozText.text = "min: \r\n" + doz.ToString("F0") + "mcg/dk = " + kg/2 + "damla/dk\r\nmax: \r\n" + (4*doz).ToString("F0") + "mcg/dk = " + (kg*2) + "damla/dk";
    }
}
