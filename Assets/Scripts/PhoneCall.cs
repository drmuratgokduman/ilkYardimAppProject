using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    public void CallNumber(string phoneNumber)
    {
        string url = "tel:" + phoneNumber;
        Application.OpenURL(url);
    }
}
