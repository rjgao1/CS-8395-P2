using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject bookinfo;
    public GameObject bookreview;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        bookinfo.SetActive(true);
        bookreview.SetActive(false);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        bookinfo.SetActive(false);
        bookreview.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        bookinfo.SetActive(true);
        bookreview.SetActive(false);
    }
}
