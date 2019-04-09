using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum StoryCharacterType
{
    NPC1,
    Doctor1,
    Doctor2   
}

[System.Serializable]
public class StoryCharacter
{
    public StoryCharacterType type;
    public Color color;
    public string name;
}

[System.Serializable]
public class DialogueActions
{
    public UnityEvent startActions;
    public UnityEvent endActions;
}


public class DialogueEntry : MonoBehaviour {

    public StoryCharacterType character;
    public AudioClip clip;
    public float time;
    public int lines;
    [TextArea (5, 5)] public string dialogue;
    public DialogueActions dialogueActions;

}
