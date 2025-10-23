using UnityEngine;
using TMPro;

public class MATH : MonoBehaviour
{

    public TextMeshProUGUI voresText;
    public int startingnumber = 10;
    private int currentnumber;
    private int activenumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentnumber = startingnumber;

        updatenumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updatenumber() 
    {
        voresText.text = currentnumber.ToString();
    }

    public void setactivenumber(int number)
    {
        activenumber = number;
    }

    public void minusnumber()
    {
        currentnumber -= activenumber;
        updatenumber();
    }

    public void plusnumber()
    {
        currentnumber += activenumber;
        updatenumber();
    }

    
}
