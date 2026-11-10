using UnityEngine;

public class ArrestPatient : MonoBehaviour
{
    private int electroshocks = 0;
    private int dontShockTurn = 0;
    [SerializeField] private TMPro.TextMeshProUGUI electroshockButtonText;
    [SerializeField] private TMPro.TextMeshProUGUI KPRText;
    [SerializeField] private GameObject Btn4H4T;
    [SerializeField] private GameObject BtnDose;
    private bool isShocking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        electroshockButtonText.text = " " + (1 + electroshocks) + ". Þok"; 
        Btn4H4T.SetActive(false);
        BtnDose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Electroshock()
    {
        electroshocks++;
        isShocking = true;
        electroshockButtonText.text = " " + (1 + electroshocks) + ". Þok";
        if(isShocking == true)
        {
            if (dontShockTurn == 0)
            {
                if (electroshocks == 1)
                {
                    KPRText.text = "*30:2 KPR\r\n*Damar yolu aç\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (electroshocks == 2)
                {
                    KPRText.text = "*30:2 KPR\r\n*Kalýcý hava yolunu aç\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (electroshocks == 3)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 300mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks == 4)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (electroshocks == 5)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 150mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks % 2 == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
            } 
            else if (dontShockTurn == 1)
            {
                if (electroshocks == 1)
                {
                    KPRText.text = "*30:2 KPR\r\n*Kalýcý hava yolunu aç\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (electroshocks == 2)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 300mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks == 3)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (electroshocks == 4)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 150mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks % 2 == 0)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
            }
            else if(dontShockTurn == 2)
            {
                if (electroshocks == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 300mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks == 2)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (electroshocks == 3)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 150mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks % 2 == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
            }
            else if(dontShockTurn % 2 == 1)
            {
                if (electroshocks == 2)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 300mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks == 4)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 150mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks % 2 == 0)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
            }
            else
            {
                if (electroshocks == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 300mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks == 3)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n*Amiadarom 150mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (electroshocks % 2 == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
            }
        }
    }
    public void DontShock()
    {
        isShocking = false;
        dontShockTurn++;
        if (isShocking == false)
        {
            if (electroshocks == 0 || electroshocks == 1)
            {
                if (dontShockTurn == 1)
                {
                    KPRText.text = "*30:2 KPR\r\n*Damar yolu aç\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else if (dontShockTurn == 2)
                {
                    KPRText.text = "*30:2 KPR\r\n*Kalýcý hava yolunu aç\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(false);
                }
                else if (dontShockTurn % 2 == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*4H4T deðerlendir\r\n";
                    Btn4H4T.SetActive(true);
                    BtnDose.SetActive(false);
                }
            } 
            else if (electroshocks%2 == 0)
            {
                if (dontShockTurn%2 == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*4H4T deðerlendir\r\n";
                    Btn4H4T.SetActive(true);
                    BtnDose.SetActive(false);
                }
            } 
            else
            {
                if (dontShockTurn % 2 == 1)
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*4H4T deðerlendir\r\n";
                    Btn4H4T.SetActive(true);
                    BtnDose.SetActive(false);
                }
                else
                {
                    KPRText.text = "*Entübe ise asenkron 2dk, yoksa 30:2 KPR\r\n*Adrenalin 1mg IV/IO\r\n";
                    Btn4H4T.SetActive(false);
                    BtnDose.SetActive(true);
                }
            }
        }
    }
}
