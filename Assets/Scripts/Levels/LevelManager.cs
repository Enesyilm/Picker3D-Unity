using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager; 
     private void Awake()
    {
        if(levelManager==null){
            levelManager=this;
            DontDestroyOnLoad(gameObject);
            InitializeLevelPrefs();
        }
        else{
            Destroy(this);
        }
       
    }

    private void InitializeLevelPrefs()
    {
        if (!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 0);

        }
        else if(PlayerPrefs.HasKey("currentLevel")){
            LoadLastLevel();
        }
    }
    public void LoadLastLevel(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentLevel"));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
