﻿/////////////////////////////////////////////////////////////
/// ゲームシーン管理クラス
/// 制作者：山下圭介
/// 作成日時：2020年3月19日
/// 更新日時：2020年6月2日
/////////////////////////////////////////////////////////////
using UnityEngine;
using Deg;

public class GameSceneManager : IScene
{
    // このクラスに対応する実際のシーン名
    private string sceneName = "GameScene";

    // 次のシーンに遷移する関数
    public IScene NextScene()
    {
        return new ResultSceneManager();
    }

    // 前のシーンに遷移する関数
    public IScene BackScene()
    {
        return new SelectSceneManager();
    }

    // 現在のシーンに入れ子になってるシーンに遷移する関数
    public IScene NestScene()
    {
        return this;
    }

    // 対応するシーン名取得用関数
    public string GetSceneName()
    {
        return sceneName;
    }
}
