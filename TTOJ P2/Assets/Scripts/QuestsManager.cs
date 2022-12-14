using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsManager : MonoBehaviour
{

    public Text currentQuestName;
    public Text whatToDoQuest;
    public static string whatToDoQuestString;

    public static List<string> AllQuests = new List<string>();
    public static List<string> UnlockedQuests = new List<string>();
    public static List<string> FinishedQuests = new List<string>();
    public static List<string> FailedQuests = new List<string>();

    string currentQuest;

    string[] AllQuestsString = {"Save the bird", "Mysterious Man", "Quest 3"};

    // Start is called before the first frame update
    void Start()
    {
        AllQuests.AddRange(AllQuestsString);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentQuest();
        whatToDoQuest.text = whatToDoQuestString;
        Debug.Log(whatToDoQuestString);
    }

    void CurrentQuest(){
        if(UnlockedQuests.Count > 1){
            currentQuest = UnlockedQuests[UnlockedQuests.Count-1];
            currentQuestName.text = currentQuest;
        } else {
            currentQuest = UnlockedQuests[0];
            currentQuestName.text = currentQuest;
        }
        
    }

}
