using UnityEngine;

public class menumanager : MonoBehaviour
{

    public GameObject VideoPanel;
    public GameObject MathPanel;
    public GameObject KebabPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changethat(string nameofpanel)
    {
        VideoPanel.SetActive(nameofpanel == "video");
        MathPanel.SetActive(nameofpanel == "math");
        KebabPanel.SetActive(nameofpanel == "kebab");
    }
}
