using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;
// check what line must be displayed and display it
public class LineReader : MonoBehaviour {

    CharacterSwitcher charswitch;
    protected StreamReader reader = null;
    private string fileNameNpc1 = "assets/Dialog.txt";
    private string fileNameNpc2 = "assets/Npc2.txt";
    [SerializeField] private Text DialogDisplay;
    public int lineNumberNpc1;
    public int lineNumberNpc2;

    public List<string> fileLinesNpc1;
    public List<string> fileLinesNpc2;

    void Start ()
    {
        charswitch = GetComponent<CharacterSwitcher>();
        ReadNpc1();
        ReadNpc2();
    }

    void ReadNpc1()
    {
        var reader = File.OpenText(fileNameNpc1);
        fileLinesNpc1 = reader.ReadToEnd().Split('\n').ToList();
        reader.Close();
        lineNumberNpc1 = 0;
    }

    void ReadNpc2()
    {
        var reader = File.OpenText(fileNameNpc2);
        fileLinesNpc2 = reader.ReadToEnd().Split('\n').ToList();
        reader.Close();
        lineNumberNpc2 = 0;
    }

    void Update ()
    {
        if (charswitch.Switcher.value == 0)
        {
            var myDataNpc1 = fileLinesNpc1[lineNumberNpc1];
            DialogDisplay.text = myDataNpc1;
        }
        else
        {
            var myDataNpc2 = fileLinesNpc2[lineNumberNpc2];
            DialogDisplay.text = myDataNpc2;
        }
	}

    public void Onchange()
    {
        lineNumberNpc1 = 0;
        lineNumberNpc2 = 0;
    }
}
