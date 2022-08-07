using UnityEngine.SceneManagement;
using UnityEngine;

public class aaa : MonoBehaviour
{
    public GameObject PAC;
    public string Tag = "Menu";

    private int ID = 0;
    private readonly string Select = "Select";

    public void Next()
    {
        ID++;
        if (ID > PAC.transform.childCount - 1)
        {
            ID = 0;
            PAC.transform.GetChild(PAC.transform.childCount - 1).gameObject.SetActive(false);
        }
        else
            PAC.transform.GetChild(ID - 1).gameObject.SetActive(false);
        PAC.transform.GetChild(ID).gameObject.SetActive(true);
        PlayerPrefs.SetInt(Select, ID);

    }
    public void Prev()
    {
        ID--;
        if (ID < 0)
        {
            ID = PAC.transform.childCount - 1;
            PAC.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
            PAC.transform.GetChild(ID + 1).gameObject.SetActive(false);
        PAC.transform.GetChild(ID).gameObject.SetActive(true);
        PlayerPrefs.SetInt(Select, ID);
    }
}
