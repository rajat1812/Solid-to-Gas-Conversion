using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Burner script;

    public Vector3 ice1 = new Vector3(-0.17f,1.14f,-4.26f);
    public Vector3 ice2 = new Vector3(0.6f,1.61f,-4f);
    public Vector3 ice3 = new Vector3(-0.14f,2.09f,-3.51f);
    public Vector3 ice4 = new Vector3(0.4f, 2.63f, -3.57f);
    public Vector3 ice5 = new Vector3(-0.11f, 3.17f, -3.58f);
    public Vector3 ice6 = new Vector3(0f,4.09f,-3.76f);
    public Vector3 water = new Vector3(0f,0.01f,0f);
    public Vector3 ices1 = new Vector3(30f,30f,30f);
   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
       
        resetBtn();
    }


    void resetBtn()
    {
        
      
        script.script7.gameObject.SetActive(true);
        script.arrow.gameObject.SetActive(true);

        //script.script1.gameObject.SetActive(false);
        //script.script2.gameObject.SetActive(false);
        //script.script3.gameObject.SetActive(false);
        //script.script4.gameObject.SetActive(false);
        //script.script5.gameObject.SetActive(false);
        //script.script6.gameObject.SetActive(false);


        script.script1.GetComponent<Rigidbody>().isKinematic = true;
        script.script2.GetComponent<Rigidbody>().isKinematic = true;
        script.script3.GetComponent<Rigidbody>().isKinematic = true;
        script.script4.GetComponent<Rigidbody>().isKinematic = true;
        script.script5.GetComponent<Rigidbody>().isKinematic = true;
        script.script6.GetComponent<Rigidbody>().isKinematic = true;


        script.slide.value = 0;
        script.vapour = false;
        script.script1.GetComponent<Rigidbody>().useGravity = false;
        script.script2.GetComponent<Rigidbody>().useGravity = false;
        script.script3.GetComponent<Rigidbody>().useGravity = false;
        script.script4.GetComponent<Rigidbody>().useGravity = false;
        script.script5.GetComponent<Rigidbody>().useGravity = false;
        script.script6.GetComponent<Rigidbody>().useGravity = false;

      


        script.ps2.Stop();
        script.ps.startLifetime = 0;
        
        script.script7.clicked = false;
       
        script.temperature = -10f;

        float w = Mathf.Round(script.temperature);
        // w += 
        print(w.ToString());

        script.t.text = w.ToString() + "°C";
       




        if (script.script7.clicked == false)
        {
            script.temp = script.arrow.transform.localPosition;
            if (script.up == false)
            {
                script.temp.y = Mathf.MoveTowards(script.temp.y, 12.8f, 2 * Time.deltaTime);

                if (script.temp.y == 12.8f)
                {
                    script.up = true;
                }
                script.arrow.transform.localPosition = script.temp;
            }

            if (script.up == true)
            {
                script.temp.y = Mathf.MoveTowards(script.temp.y, 12f, 2 * Time.deltaTime);

                if (script.temp.y == 12f)
                {
                    script.up = false;
                }
                script.arrow.transform.localPosition = script.temp;
            }


        }




        script.script1.transform.localPosition = ice1;
        script.script2.transform.localPosition = ice2;
        script.script3.transform.localPosition = ice3;
        script.script4.transform.localPosition = ice4;
        script.script5.transform.localPosition = ice5;
        script.script6.transform.localPosition = ice6;



        script.script.s.transform.localScale = water;
        script.script.gameObject.SetActive(false);

      

        script.script1.transform.localScale = ices1;
        script.script2.transform.localScale = ices1;
        script.script3.transform.localScale = ices1;
        script.script4.transform.localScale = ices1;
        script.script5.transform.localScale = ices1;
        script.script6.transform.localScale = ices1;



        script.script1.gameObject.SetActive(true);
        script.script2.gameObject.SetActive(true);
        script.script3.gameObject.SetActive(true);
        script.script4.gameObject.SetActive(true);
        script.script5.gameObject.SetActive(true);
        script.script6.gameObject.SetActive(true);

    }
}
