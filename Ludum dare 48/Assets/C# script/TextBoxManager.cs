using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextBoxManager : MonoBehaviour
{

    public GameObject TextBox;
    public TMPro.TMP_Text textObj;

    public int currentLine;
    public int endAtLine;

    public PlayerMovementScript player;

    public TextAsset textFile;
    public string[] textLines;
    // Start is called before the first frame update
    void Start() {

        player = FindObjectOfType<PlayerMovementScript>();

        if (textFile != null) {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0) {
            endAtLine = textLines.Length - 1;
        }


    }

    void Update () {
        textObj.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return)) {
            currentLine += 1;
        }

        if (currentLine > endAtLine) {
            TextBox.SetActive(false);
        }
    }
}
