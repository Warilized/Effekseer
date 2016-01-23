﻿Effekseer
=========
本ソフトウェア及びランタイムはオープンソースにて開発しているヴィジュアルエフェクト編集ツール・再生用ランタイムです。
主にゲームに組み込み使用しており、パーティクル等ヴィジュアルエフェクトをプログラマでなくデザイナが担当できるようにすること想定しています。

* [公式ウェブサイト](http://effekseer.github.io/jp/)

**不具合情報**

現在、UnityMac版ではLegacyDefferedとForwardのみ描画対応しています。不具合の原因は現在調査中です。

# RoadMap

**Version 1.10**
* ?

# Todo
プルリクエストお待ちしております。

**小規模な追加・変更**
* ドキュメントの改良
* 文言の改良
* 各種アイコンの追加
* サンプルの追加
* Windows、Linux以外のテストの構築

**中規模な追加・変更**
* Effectのパラメーターの動的な変更
* ショートカットの見直し
* モデル出力プラグイン(Blender等)


**大規模な追加・変更**
* ツールのGUIライブラリの変更
* ツールのマルチプラットフォーム化

**他**
* 英語版対応
* DirectX12対応
* UnrealEngine4, Cocos2D対応
* iPhone,Android対応
* ガンマ表示オプション

# コミッター向け

## ランタイムテスト方法

* Windows

```Dev/Cpp/Test.sln``` を実行する。

* Linux

```Dev/Cpp/build.sh``` を実行する。
```Dev/Cpp/Test/CMakeLists.txt``` をcmakeを使用してmakeを生成しコンパイルする。

* Mac

不明

