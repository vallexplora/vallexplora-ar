using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI arText;
    private string instructions = "Scan the Vallexplora logo to reveal the information.";

    private int TEXT_CHUNK_SIZE = 70;

    private int textIndex = 0;
    private string comingText = "In Valle del Cauca, Colombia, vibrant salsa rhythms meet breathtaking landscapes. ⛰️ Experience the \"World's Salsa Capital\" in Cali, then venture into the Andes for coffee plantations and charming towns. ☕ Relax on Pacific beaches, explore lush rainforests, or spot exotic birds in Farallones National Park.  Unwind in hot springs or discover ancient treasures at the Calima Gold Museum. ♨️ Valle del Cauca offers something for everyone.";
    List<string> arParagraphs = new List<string>();

    public void TrimText()
    {
        string[] dividedText = Regex.Split(comingText, @"\s+");

        int textLenght = 0;
        string textChunk = "";

        foreach (string word in dividedText)
        {
            if (textLenght < TEXT_CHUNK_SIZE)
            {
                textLenght += word.Length;
                textChunk += (word + " ");
            }
            else
            {
                textChunk += (word + ".");
                arParagraphs.Add(textChunk);
                textLenght = 0;
                textChunk = "";

            }
        }
    }

    public void ButtonChangeAction()
    {
        if (arParagraphs.Count > 0 & arParagraphs.Count > textIndex+1)
        {
            arText.text = arParagraphs[textIndex];
            textIndex++;
        }
    }

    public void Start()
    {
        arText.text = instructions;
        TrimText();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
