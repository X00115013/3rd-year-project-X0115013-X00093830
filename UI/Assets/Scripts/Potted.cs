using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Potted : MonoBehaviour {

    public static bool ballOrder;
    public static bool allRed;
    public static bool pink, blue, brown, green, yellow, black, white;
    public static bool [] redHistory = { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
    public static int score;
    public Text countText;


    // Use this for initialization
    void Start () {
        //redHistory= new bool[16];
        pink = true;
        blue = true;
        brown = true;
        green = true;
        yellow = true;
        black = true;
        white = true;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        GameObject temp;
        Rigidbody rb;
        if (col.gameObject.name == "RedBall1")
        {
            Destroy(col.gameObject);
            ballOrder = false;
            redHistory[0] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (1)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[1] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (2)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[2] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (3)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[3] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (4)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[4] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (5)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[5] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);

        }
        else if (col.gameObject.name == "RedBall1 (6)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[6] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (7)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[7] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (8)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[8] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (9)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[9] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (10)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[10] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (11)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[11] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (12)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[12] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (13)")
        {
            //Destroy(col.gameObject);
            ballOrder = false;
            redHistory[13] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "RedBall1 (14)")
        {
            ballOrder = false;
            redHistory[14] = false;
            score += 1;
            setCountText();
            Destroy(col.gameObject);
        }

        //Pink Ball
        else if (col.gameObject.name == "PinkBall")
        {
            for(int i = 0;i < redHistory.Length; i++)
            {
                if(redHistory[i]== true)
                {
                    allRed = false;
                    i = redHistory.Length;
                }

            }
            if (ballOrder == false && allRed == false)
            {
                temp = GameObject.Find("PinkBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(-45f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                score += 6;
                setCountText();
            }
            else if (ballOrder == true && allRed == true)
            {
                temp = GameObject.Find("PinkBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(-45f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                allRed = false;
                score += 6;
                setCountText();
            }
            else if (ballOrder == false && allRed == true)
            {
                Destroy(col.gameObject);
                ballOrder = false;
                pink = false;
                score +=  6;
                setCountText();
            }
        }
        else if (col.gameObject.name == "BlueBall")
        {
            for (int i = 0; i < redHistory.Length; i++)
            {
                if (redHistory[i] == true)
                {
                    allRed = false;
                    i = redHistory.Length;
                }

            }
            if (ballOrder == false && allRed == false)
            {
                temp = GameObject.Find("BlueBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(-20f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                score += 5;
                setCountText();
            }
            else if (ballOrder == true && allRed == true)
            {
                temp = GameObject.Find("BlueBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(-20f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                blue = false;
                score += 5;
                setCountText();
            }
            else if (ballOrder == false && allRed == true)
            {
                Destroy(col.gameObject);
                ballOrder = false;
                pink = false;
                score += 5;
                setCountText();
            }
        }
        else if (col.gameObject.name == "YellowBall")
        {
            for (int i = 0; i < redHistory.Length; i++)
            {
                if (redHistory[i] == true)
                {
                    allRed = false;
                    i = redHistory.Length;
                }

            }
            if (ballOrder == false && allRed == false)
            {
                temp = GameObject.Find("YellowBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(10f, 0f, 20f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                score += 2;
                setCountText();
            }
            else if (ballOrder == true && allRed == true)
            {
                temp = GameObject.Find("YellowBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(10f, 0f, 20f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                yellow = false;
                score += 2;
                setCountText();
            }
            else if (ballOrder == false && allRed == true)
            {
                Destroy(col.gameObject);
                ballOrder = true;
                pink = false;
                score += 2;
                setCountText();
            }
        }
        else if (col.gameObject.name == "BrownBall")
        {
            for (int i = 0; i < redHistory.Length; i++)
            {
                if (redHistory[i] == true)
                {
                    allRed = false;
                    i = redHistory.Length;
                }

            }
            if (ballOrder == false && allRed == false)
            {
                temp = GameObject.Find("BrownBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(10f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                score += 4;
                setCountText();
            }
            else if (ballOrder == true && allRed == true)
            {
                temp = GameObject.Find("BrownBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(10f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                brown = false;
                score += 4;
                setCountText();
            }
            else if (ballOrder == false && allRed == true)
            {
                Destroy(col.gameObject);
                ballOrder = true;
                pink = false;
                score += 4;
                setCountText();
            }
        }
        else if (col.gameObject.name == "GreenBall")
        {
            for (int i = 0; i < redHistory.Length; i++)
            {
                if (redHistory[i] == true)
                {
                    allRed = false;
                    i = redHistory.Length;
                }

            }
            if (ballOrder == false && allRed == false)
            {
                temp = GameObject.Find("GreenBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(10f, 0f, -15f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                score += 3;
                setCountText();
            }
            else if (ballOrder == true && allRed == true)
            {
                temp = GameObject.Find("GreenBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(10f, 0f, -15f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                green = false;
                score += 3;
                setCountText();
            }
            else if (ballOrder == false && allRed == true)
            {
                Destroy(col.gameObject);
                ballOrder = true;
                pink = false;
                score += 3;
                setCountText();
            }
        }
        else if (col.gameObject.name == "BlackBall")
        {
            for (int i = 0; i < redHistory.Length; i++)
            {
                if (redHistory[i] == true)
                {
                    allRed = false;
                    i = redHistory.Length;
                }

            }
            if (ballOrder == false && allRed == false)
            {
                temp = GameObject.Find("BlackBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(-85f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                score += 7;
                setCountText();
            }
            else if (ballOrder == true && allRed == true)
            {
                temp = GameObject.Find("BlackBall");
                rb = temp.GetComponent<Rigidbody>();
                //rb.velocity = Vector3.zero;
                temp.transform.position = new Vector3(-85f, 0f, 3.5f);
                rb.velocity = Vector3.zero;
                ballOrder = true;
                black = false;
                score += 7;
                setCountText();
            }
            else if (ballOrder == false && allRed == true)
            {
                Destroy(col.gameObject);
                ballOrder = true;
                pink = false;
                score += 7;
                setCountText();
            }
        }
        else if (col.gameObject.name == "WhiteBall")
        {
            temp = GameObject.Find("WhiteBall");
            rb = temp.GetComponent<Rigidbody>();
            //rb.velocity = Vector3.zero;
            StartCoroutine(MyMethod());
            temp.transform.position = new Vector3(17f, 0f, 11f);
            rb.velocity = Vector3.zero;
            score = score - 1;
            setCountText();
        }
    }
    void setCountText()
    {
        Debug.Log("Score: " + score.ToString());
        countText.text = "Score: " + score.ToString();
    }
    IEnumerator MyMethod()
    {
        Debug.Log("Before Waiting 5 seconds");
        yield return new WaitForSeconds(5);
        Debug.Log("After Waiting 5 Seconds");
        yield break;
    }
}
