using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Character manager= responsible for adding and maintaining characters.
/// </summary>
public class characterManager : MonoBehaviour {

    public static characterManager instance;

    /// <summary>
    /// The character panel, where everything will be attatched.
    /// </summary>
    public RectTransform characterPanel;

    /// <summary>
    /// list of characters in scene
    /// </summary>
    public List<Character> characters = new List<Character>();

    public Dictionary<string, int> characterDictionary = new Dictionary<string, int>();

    private void Awake()
    {
        instance = this;
    }

    /// <summary>
    /// Gets the character by name on the list.
    /// </summary>
    /// <param name="characterName">Character name.</param>
    public Character GetCharacter(string characterName, bool createCharacterIfDoesNotExist = true){
        int index = -1;
        if(characterDictionary.TryGetValue(characterName, out index)){
            return characters[index];
        }else if(createCharacterIfDoesNotExist){
            return CreateCharacter(characterName);
        }
        return null;
    }
    public Character CreateCharacter(string characterName){
        Character newCharacter = new Character(characterName);

        characterDictionary.Add(characterName, characters.Count);
        characters.Add(newCharacter);

        return newCharacter;
    }
}
