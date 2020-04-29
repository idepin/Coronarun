using UnityEngine;

[CreateAssetMenu(fileName = "UserData", menuName = "DataUser/UserData", order = 1)]
public class UserData : ScriptableObject
{
    public string username;
    public float highestScore;
}
