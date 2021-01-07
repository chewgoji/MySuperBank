## 建立solution with CLI

[.net 101](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oWoazjhXQzBKMrFuArxpW80)

[Create a .NET class library using Visual Studio Code(project reference)](https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code)

[使用 dotnet test 與 xUnit 為 .NET Core 中的 C# 進行單元測試](https://docs.microsoft.com/zh-tw/dotnet/core/testing/unit-testing-with-dotnet-test)
1. dotnet cli 
```
dotnet -h
```
2. create solution file
```
dotnet new sln
```
:::info
```dotnet new -l``` 查看所有 Templates
:::
3. create asp.net core web api
```
dotnet new webapi -o API 
/*-o, --output Location to place the generated output.*/
```
4. add API into solution
```
dotnet sln add API
```
:::info
範例
==```dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj```== ShowCase(console)中加入StringLibary(libary)

:::
## VS code setting
### Extention
* C# for Visual Studio Code (powered by OmniSharp)
* C# Extensions (找到還有在維護的)
* Material Icon Theme (好看用)(Material Icon Theme)
* NuGet Gallery
* SQLite

### Setting
* Auto save
```flow
st=>start: VScode
e=>end: Cheacked
op=>operation: File
cond=>condition: Auto Save

st->op->cond
cond(yes)->e
cond(no)->op
```
* Exculde ==obj== and ==bin== //無視文件

```flow
st=>start: vscode
op=>operation: preference
op2=>operation: setting
op3=>operation: Search Exculde
op4=>operation: Add Pattern **/bin,**/obj

st->op->op2->op3->op4
```

## Nuget
* Microsoft.EntityFrameworkCore.Sqlite
* Microsoft.EntityFrameworkCore.Design
* dotnet-ef
```flow
st=>start: nuget.org
op=>operation: search dotnet-ef
op2=>operation: find your version
op3=>operation: Use .Net CLI to install

st->op->op2->op3
```
creat migration
```
dotnet ef migrations add InitialCreate -o Data/Migrations
```

update database
```
dotnet ef database update
```

