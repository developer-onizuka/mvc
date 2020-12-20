
1. dockerの基本
 (1)　コンテナを起動する。
 (2)　起動したコンテナの中にログインする。
 (3)　NGiNXにブラウザでアクセスする。

2. dotnetの基本
 (1)　なぜC#か？
 　　https://ufcpp.net/study/csharp/getstarted.html
 (2)　dotnetでHello Worldを書いてみる。
 　　https://docs.microsoft.com/ja-jp/dotnet/csharp/tour-of-csharp/

3.　配列
　　https://ufcpp.net/study/csharp/st_array.html

4.　構造体
　　https://itsakura.com/csharp-struct
  
5.  メソッド（関数）
 (1) Hello World 
 (2) add
 (3) add2
  
6.  クラス（メソッド、関数）
 (1) Calculation
 (2) Video

7.　ライブラリ
　　https://imagingsolution.net/program/csharp/build_csharp_dll/

8. List 
    https://programming.pc-note.net/csharp/list.html

9. ラムダ式
    https://csharp-ref.com/program_linq-lambda.html
    https://programming.pc-note.net/csharp/lambda.html

10. ToStringメソッド
    https://shabonlearning.com/cSharp/csharp_kiso7.html

11. MVCを使ってアプリを作る 
    http://www.binaryintellect.net/articles/b6f251ee-0dd9-4741-8928-107a62b63e74.aspx

(1) Models/EmoloyeeEntity.cs
    表に入れるデータと型を定義する。
(2) Contorllers/HomeControllers
    ① 使用するライブラリを定義する。 
    ② DBに接続する。
    ③ Listクラスを使ったインスタンスを定義する。
    ④ Listインスタンスをメソッドで操作する。
	https://www.sejuku.net/blog/41093
        https://csharp-ref.com/collection_list.html
	  - Add
          - FindAll
	  - Exists
	  - Insert
          - RemoveAt
    ⑤ FindAllしたList構造をView()に食わせる。    
	- @Model
        https://aspnet.keicode.com/basic/aspnet-mvc-strongly-typed-view.php
	- タグヘルパー：
	https://blog.shibayan.jp/entry/20170725/1500966960
