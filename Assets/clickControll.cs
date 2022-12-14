using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clickControll : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update

    public TMP_Text num1text;
    public int index;
    public TMP_Text operand1text;
    public TMP_Text operand2text;
    public Button button;
    public Image image;
    public Image bingo_image;
    public static int r1 = 0;
    public static int r2 = 0;
    public static int r3 = 0;
    public static int r4 = 0;
    public static int r5 = 0;
    public static int c1 = 0;
    public static int c2 = 0;
    public static int c3 = 0;
    public static int c4 = 0;
    public static int c5 = 0;
    public static int d1 = 0;
    public static int d2 = 0;

    void Start()
    {
        //Debug.Log("cc"+index);
        num1text.text = GMScript.test[index].ToString();
        image.enabled = false;
    }
   

    public void OnPointerClick(PointerEventData eventData)
    {
        int currquesint = GMScript.index;
        int o1 = GMScript.operator1[currquesint];
        int o2 = GMScript.operator2[currquesint];

        //Debug.Log("in click control");
        if(o2==0 || o2==1){
            GMScript.questions_types_total[0] += 1;
            if(GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[0] += 1;
            }
        }
        if (o1 == o2 * 2 && o1<10)
        {
            GMScript.questions_types_total[1] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[1] += 1;
            }
        }
        if(o1 == o2 * 2 && o1 >= 10 && o1 <= 99)
        {
            GMScript.questions_types_total[2] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[2] += 1;
            }
        }
        if (o1 == 10)
        {
            GMScript.questions_types_total[3] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[3] += 1;
            }
        }
        if(o1>=10 && o1<=20 && o2 == 10)
        {
            GMScript.questions_types_total[4] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[4] += 1;
            }
        }
        if (o1 == o2 * 2 + 1)
        {
            GMScript.questions_types_total[5] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[5] += 1;
            }
        }
        if(o1==9 || o1 == 11)
        {
            GMScript.questions_types_total[6] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[6] += 1;
            }
        }
        if (o1 == o2 - 2)
        {
            GMScript.questions_types_total[7] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[7] += 1;
            }
        }
        if(o2==2)
        {
            GMScript.questions_types_total[8] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[8] += 1;
            }
        }
        if (o2 == 10)
        {
            GMScript.questions_types_total[9] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[9] += 1;
            }
        }
        if (o1<20)
        {
            GMScript.questions_types_total[10] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[10] += 1;
            }
        }
        if(o1>=20 && o1 <= 30)
        {
            GMScript.questions_types_total[11] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[11] += 1;
            }
        }
        if (o1 > 30 && o1 <= 50)
        {
            GMScript.questions_types_total[13] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[13] += 1;
            }
        }
        if (o1 > 50 && o1 <= 100)
        {
            GMScript.questions_types_total[14] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[12] += 1;
            }
        }
        if (o2 >= 10 && o2 <= 99)
        {
            GMScript.questions_types_total[14] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[13] += 1;
            }
        }
        if (o1 >= 100 && o2 >= 10 && o2 <= 99)
        {
            GMScript.questions_types_total[15] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[15] += 1;
            }
        }
        if(o1>=100 && o2 >= 100)
        {
            GMScript.questions_types_total[16] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[16] += 1;
            }
        }


        if (GMScript.test[index] == o1-o2)
        {

            //Debug.Log("correct ans");
            //button.GetComponent<Image>().sprite= image;
            image.enabled = true;
            //num1text.text = "";
            GMScript.result[index] = true;
            //button.GetComponent<Button>().interactable = false;

            if(index!=0 & index!=24 & index % 4 == 0)
            {
                d1 += 1;
                if (d1 == 5)
                {
                    bingoresponse();
                }
            }
            if (index % 6 == 0)
            {
                d2 += 1;
                if (d2 == 5)
                {
                    bingoresponse();
                }
            }

            switch (index % 5){
                case 0:
                    c1 += 1;
                    //Debug.Log("C count:-----------"+c1);
                    if (c1 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("C count:-----------" + c2);
                    c2 += 1;
                    if (c2 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 2:
                    //Debug.Log("C count:-----------" + c3);
                    c3 += 1;
                    if (c3 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 3:
                    c4 += 1;
                    if (c4 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 4:
                    c5 += 1;
                    if (c5 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                default:
                    break;
            }
            switch (index/5)
            {
                case 0:
                    r1 += 1;
                    //Debug.Log("R count:-----------" + r1);
                    if (r1 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("R count:-----------" + r2);
                    r2 += 1;
                    if (r2 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 2:
                    r3 += 1;
                    if (r3 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 3:
                    r4 += 1;
                    if (r4 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 4:
                    r5 += 1;
                    if (r5 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
            //button.GetComponent<Button>().interactable = false;
            button.gameObject.SetActive(false);
            //Debug.Log("incorrect ans");
        }
        
        GMScript.index = currquesint+1;
        if (currquesint < 24) {
            operand1text.text = GMScript.operator1[currquesint+1].ToString();
            operand2text.text = GMScript.operator2[currquesint+1].ToString();
        }
        //Debug.Log("button number" + index + " clicked");
    }
    //public void buttontesting()
    //{
    //    Debug.Log("button"+index+"clicked!");
    //}
    public void bingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
    }

    
}
