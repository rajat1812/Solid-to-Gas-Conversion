using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Burner : MonoBehaviour 
{
    
   
    public ParticleSystem ps;
    public ParticleSystem ps2;
    public Text t;
    public Slider slide;

    public bool vapour;
    public bool up;
    // public int i = -10;
    public float meltingTime;
    public float temperature;
    public float speed;
    public float w;

    public GameObject arrow;
    public GameObject reset;

    public Water script;
    public Vector3 temp;
    public Vector3 temp1;
    public Vector3 temp2;
    public Vector3 temp3;
    public Vector3 temp4;
    public Vector3 temp5;
    public Vector3 temp6;
    public Vector3 temp7;

    public Cube1 script1;
    public Cube2 script2; 
    public Cube3 script3;
    public Cube4 script4;
    public Cube5 script5;
    public Cube6 script6;
    public IceStart script7;
   
   

public float speedy = 10.0f;

    

    // Start is called before the first frame update
    void Start()
    {   

      
        vapour = false;
        //script1.GetComponent<Rigidbody>().
       
        script1.GetComponent<Rigidbody>().useGravity = false;
        script2.GetComponent<Rigidbody>().useGravity = false;
        script3.GetComponent<Rigidbody>().useGravity = false;
        script4.GetComponent<Rigidbody>().useGravity = false;
        script5.GetComponent<Rigidbody>().useGravity = false;
        script6.GetComponent<Rigidbody>().useGravity = false;
      
         ps2.Stop();
         script.gameObject.SetActive(false);
         temperature = -10f;
       
    }

  

    // Update is called once per frame
    void Update()
    {

        

        //script6.transform.position.x += Input.GetAxis("Horizontal") * 10 * Time.deltaTime;


        if (script7.clicked == false)
        {
            temp7 = arrow.transform.localPosition;
            if (up == false)
            {
                temp7.y = Mathf.MoveTowards(temp7.y, 12.8f, 2 * Time.deltaTime);

                if (temp7.y == 12.8f)
                {
                    up = true;
                }
                arrow.transform.localPosition = temp7;
            }

            if (up == true)
            {
                temp7.y = Mathf.MoveTowards(temp7.y, 12f, 2 * Time.deltaTime);

                if (temp7.y == 12f)
                {
                    up = false;
                }
                arrow.transform.localPosition = temp7;
            }


        }



        if(script7.clicked == true)

        {

            script7.gameObject.SetActive(false);
            arrow.gameObject.SetActive(false);


            script1.GetComponent<Rigidbody>().useGravity = true;
            script2.GetComponent<Rigidbody>().useGravity = true;
            script3.GetComponent<Rigidbody>().useGravity = true;
            script4.GetComponent<Rigidbody>().useGravity = true;
            script5.GetComponent<Rigidbody>().useGravity = true;
            script6.GetComponent<Rigidbody>().useGravity = true;
          

            temp = script.s.localScale;

            temp1 = script1.transform.localScale;
            temp2 = script2.transform.localScale;
            temp3 = script3.transform.localScale;
            temp4 = script4.transform.localScale;
            temp5 = script5.transform.localScale;
            temp6 = script6.transform.localScale;

            if (temperature > 0 && temperature < 4)
            {
               
                if (ps.time > 4.0)
                {
                    script.gameObject.SetActive(true);

                    if (temp.x >= 1.05 && temp.z >= 1.05)
                    {
                        if (temp.y <= 11)
                        {
                            if (temp4.x > 0 && temp4.y > 0 && temp4.z > 0)
                            {

                                temp4.x -= Time.deltaTime * 0.4f * speed;
                                temp4.y -= Time.deltaTime * 0.5f * speed;
                                temp4.z -= Time.deltaTime * 0.5f * speed;
                            }



                            if (temp4.x <= 24)
                            {
                                if (temp1.x > 0 && temp1.y > 0 && temp1.z > 0)
                                {
                                    temp1.x -= Time.deltaTime * 0.4f * speed;
                                    temp1.y -= Time.deltaTime * 0.5f * speed;
                                    temp1.z -= Time.deltaTime * 0.5f * speed;
                                }

                                if (temp1.x <= 24)
                                {
                                    if (temp3.x > 0 && temp3.y > 0 && temp3.z > 0)
                                    {
                                        temp3.x -= Time.deltaTime * 0.5f * speed;
                                        temp3.y -= Time.deltaTime * 0.5f * speed;
                                        temp3.z -= Time.deltaTime * 0.4f * speed; ;
                                    }

                                    if (temp3.x <= 20)
                                    {
                                        if (temp2.x > 0 && temp2.y > 0 && temp2.z > 0)
                                        {
                                            temp2.x -= Time.deltaTime * 0.5f * speed;
                                            temp2.y -= Time.deltaTime * 0.4f * speed;
                                            temp2.z -= Time.deltaTime * 0.5f * speed;
                                        }

                                        if (temp2.x <= 24)
                                        {
                                            if (temp6.x > 0 && temp6.y > 0 && temp6.z > 0)
                                            {
                                                temp6.x -= Time.deltaTime * 0.5f * speed;
                                                temp6.y -= Time.deltaTime * 0.4f * speed;
                                                temp6.z -= Time.deltaTime * 0.5f * speed;
                                            }

                                            if (temp6.x <= 20)
                                            {
                                                if (temp5.x > 0 && temp5.y > 0 && temp5.z > 0)
                                                {
                                                    temp5.x -= Time.deltaTime * 0.5f * speed;
                                                    temp5.y -= Time.deltaTime * 0.5f * speed;
                                                    temp5.z -= Time.deltaTime * 0.4f * speed;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //else
                        //{
                        if (temp.y <= 11)
                        {
                            temp.y += Time.deltaTime * 0.075f * speed;
                        }


                        script1.transform.localScale = temp1;
                        script2.transform.localScale = temp2;
                        script3.transform.localScale = temp3;
                        script4.transform.localScale = temp4;
                        script5.transform.localScale = temp5;
                        script6.transform.localScale = temp6;

                        script.s.localScale = temp;
                        //     }



                    }
                    else
                    {
                        temp.x += Time.deltaTime * 0.05f * speed;
                        temp.z += Time.deltaTime * 0.05f * speed;
                        script.s.localScale = temp;

                    }
                }
            }






            if (temperature > 0 && temperature < 4)
            {
                temperature += speed * (Time.deltaTime * 0.02f);
            }
            else if (temperature >= 100)
            {
                temperature += speed * (Time.deltaTime * 0.1f);
                print(ps2.time);
                if (vapour == false)
                {
                    Invoke("vapours", 0.1f);
                    vapour = true;
                }

            }
            else
            {
                temperature += speed * (Time.deltaTime * 1f);
            }



            w = Mathf.Round(temperature);
            // w += 
            print(w.ToString());

            t.text = w.ToString() + "°C";
            // print(t.text);

            //print(temperature);
            //if (temperature > 25)
            //{

            //}
        }





    }


    //void vapour()
    //{
    //    ps2.Play();
    //}

    public void Slider_Changed(float value)
    {
        if (value == 0)
        {
            ps.startLifetime = 0;
        }
        else{
            ps.startLifetime = 1.5f;
        }
     
        speed = value;
        ps.startSpeed = value*2;
       
        print(ps);
    }



    void vapours()
    {
        ps2.Play();
        
    }




}
