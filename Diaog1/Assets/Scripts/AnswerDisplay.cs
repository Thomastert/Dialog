using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerDisplay : MonoBehaviour {
    [SerializeField] private GameObject  QuestionDisplay;
    [SerializeField]
    private Text answer1;
    [SerializeField]
    private Text answer2;
    [SerializeField]
    private Text answer3;
    public bool question1;
    public bool question2;
    CharacterSwitcher charswitch;
    LineReader linereader;

    void Start ()
    {
        linereader = GetComponent<LineReader>();
        charswitch = GetComponent<CharacterSwitcher>();
        question1 = false;
	}

	void Update ()
    {
        UpdateAnswers();

        if (linereader.lineNumberNpc1 == 1 || linereader.lineNumberNpc2 == 1)
        {
            question1 = true;
            QuestionDisplay.SetActive(true);
        }
        else if (linereader.lineNumberNpc1 == 6 || linereader.lineNumberNpc2 == 6)
        {
            question2 = true;
            QuestionDisplay.SetActive(true);
        }
        else if (linereader.lineNumberNpc1 == 16 || linereader.lineNumberNpc2 == 16)
        {
            question2 = true;
            QuestionDisplay.SetActive(true);
        }
        else if (linereader.lineNumberNpc1 == 24 || linereader.lineNumberNpc2 == 24)
        {
            question2 = true;
            QuestionDisplay.SetActive(true);
        }
        else
        {
            question1 = false;
            question2 = false;
            QuestionDisplay.SetActive(false);
        }

	}

    void UpdateAnswers()
    {
        if (question1 == true)
        {
            if (charswitch.Switcher.value == 0)
            {
                answer1.text = "I would like some Nootalla";
                answer2.text = "Do u have a fish for me?";
                answer3.text = "Wait u can talk?";
            }
            else if (charswitch.Switcher.value == 1)
            {
                answer1.text = "Yes please i feel so dirty";
                answer2.text = "maybe just a little clean";
                answer3.text = "No i don't think u where meant for humans";
            }
        }
        if (question2 == true)
        {
            if (charswitch.Switcher.value == 0)
            {
                answer1.text = "Noot";
                answer2.text = "Noot";
                answer3.text = "Noot";
            }
            else if (charswitch.Switcher.value == 1)
            {
                answer1.text = "Yes please i feel so dirty";
                answer2.text = "maybe just a little clean";
                answer3.text = "No i don't think u where meant for humans";
            }
        }
    }
}
