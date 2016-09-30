using UnityEngine;
using System.Collections;

public class AnswerChecker : MonoBehaviour {
    AnswerDisplay answerdisplay;
    LineReader linereader;
    [SerializeField]private GameObject Next;

    void Start ()
    {
        answerdisplay = GetComponent<AnswerDisplay>();
        linereader = GetComponent<LineReader>();
    }

	void Update ()
    {
        if (answerdisplay.question1 == true)
        {
            Next.SetActive(false);
        }
        else if (answerdisplay.question2 == true)
        {
            Next.SetActive(false);
        }
        else
        {
            Next.SetActive(true);
        }
	}

    public void Answer1()
    {
        if (answerdisplay.question1 == true)
        {
            linereader.lineNumberNpc1 = 3;
            linereader.lineNumberNpc2 = 3;
            answerdisplay.question1 = false;
        }
    }

    public void Answer2()
    {
        if (answerdisplay.question1 == true)
        {
            linereader.lineNumberNpc1 = 12;
            linereader.lineNumberNpc2 = 12;
            answerdisplay.question1 = false;
        }
    }

    public void Answer3()
    {
        if (answerdisplay.question1 == true)
        {
            linereader.lineNumberNpc1 = 21;
            linereader.lineNumberNpc2 = 21;
            answerdisplay.question1 = false;
        }
    }
}
