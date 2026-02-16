using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleManager : MonoBehaviour
{
    public string sceneName; //スタートボタンを押して読み込むシーン名
    //public InputAction submitAction; //決定のInputAction;

    //void OnEnable()
    //{
    //    submitAction.Enable(); //InputActionを有効化
    //}
    //void OnDisable()
    //{
    //    submitAction.Disable(); //InputActionを無効化
    //}

    //InputSystem?Actionsで決めたUIマップのSubmitアクションが押されたとき
    void OnSubmit(InputValue valuse)
    {
        Load();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ////インスペクター上で登録したキーのいずれかがおされていたら成立
        //if (submitAction.WasPressedThisFrame())
        //{
        //    Load();
        //}

        ////列挙型のKeyboard型の値を変数kbに代入
        //Keyboard kb = Keyboard.current;
        //if(kb != null) //キーボードがつながっていれば
        //{
        //    //エンターキーがおされた状態なら
        //    if (kb.enterKey.wasPressedThisFrame)
        //    {
        //        Load();
        //    }
        //}
    }

    //シーンを読み込むメソッド作成
    public void Load()
    {
        GameManager.totalScore = 0; //新しくゲームを始めるにあたってスコアをリセット
        SceneManager.LoadScene(sceneName);
    }
}
