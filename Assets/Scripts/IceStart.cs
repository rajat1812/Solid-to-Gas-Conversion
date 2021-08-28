using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceStart : MonoBehaviour
{
    public bool clicked;
    public Burner script;

    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnMouseDown()
    {
        clicked = true;
        print(clicked);



        script.script1.GetComponent<Rigidbody>().isKinematic = false;
        script.script2.GetComponent<Rigidbody>().isKinematic = false;
        script.script3.GetComponent<Rigidbody>().isKinematic = false;
        script.script4.GetComponent<Rigidbody>().isKinematic = false;
        script.script5.GetComponent<Rigidbody>().isKinematic = false;
        script.script6.GetComponent<Rigidbody>().isKinematic = false;
    }
}
