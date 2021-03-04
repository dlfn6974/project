using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string name;
    private int level = 1;
    public Player(string _name){
        this.name = _name;
    }
    public void Getinfo()
    {
        Debug.Log("이름:  + this.name");
        Debug.Log("레벨:  + this.level");
    }
    public void levelup()
    {
        this.level++;
        Debug.Log("레벨 업");
    }
}
public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myplayer = new Player("정재규");
        myplayer.Getinfo();
        myplayer.levelup();
        myplayer.Getinfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
