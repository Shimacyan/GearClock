using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text timeText; // Text オブジェクトを格納する変数
    private float elapsedTime = 0f; // 経過時間を格納する変数
    public int days = 0; // 経過日数を格納する変数

    void Update()
    {
        // 経過時間を加算
        elapsedTime += Time.deltaTime;

        // 日、時、分、秒を計算
        days = Mathf.FloorToInt(elapsedTime / 86400f); // 日数を計算
        int hours = Mathf.FloorToInt((elapsedTime % 86400f) / 3600f); // 残りの秒から時間を計算
        int minutes = Mathf.FloorToInt((elapsedTime % 3600f) / 60f); // 残りの秒から分を計算
        int seconds = Mathf.FloorToInt(elapsedTime % 60f); // 残りの秒から秒を計算

        // テキストに経過時間を表示
        timeText.text = string.Format("経過時間: {0}日 {1}時間 {2}分 {3}秒", days, hours, minutes, seconds);
    }
}