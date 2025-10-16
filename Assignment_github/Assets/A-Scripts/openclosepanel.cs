using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class openclosepanel : MonoBehaviour
{
    public Canvas moreinfo;
    public Button moreinfobutton;
    public GameObject mioopencube;
    public GameObject mioopentext;
    // Start is called before the first frame update
    void Start()
    {
        moreinfobutton.onClick.AddListener(()=>{
            moreinfo.enabled = false;
            mioopencube.GetComponent<Renderer>().enabled = true;
            mioopentext.GetComponent<Renderer>().enabled = true;
        });
    }


    // Update is called once per frame
    void Update()
    {
       
    }


}
